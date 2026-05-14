using BloodBankApp.Data;
using BloodBankApp.Models;
using BloodBankApp.Services;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class IssueForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly AuditService _auditService;
        private readonly CurrentUserService _userService;
        private bool _isBusy = false;
        private Models.Request? _selectedRequest;
        private Models.BloodUnit? _selectedUnit;

        public IssueForm(AppDbContext dbContext, AuditService auditService, CurrentUserService userService)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _auditService = auditService;
            _userService = userService;
        }

        private async void IssueForm_Load(object sender, EventArgs e)
        {
            await LoadPendingRequests();
        }

        private async Task LoadPendingRequests()
        {
            _isBusy = true;

            var requests = await _dbContext.Requests
                .Where(r => r.Status == "Pending")
                .Include(r => r.Patient)
                .Select(r => new
                {
                    r.Id,
                    PatientName = r.Patient == null ? "N/A" : (r.Patient.FirstName + " " + r.Patient.LastName),
                    r.BloodGroup,
                    r.UnitsRequired,
                    r.RequestDate,
                    r.Status
                })
                .ToListAsync();

            dgvRequests.DataSource = requests;

            dgvRequests.ClearSelection();
            dgvUnits.DataSource = null;
            _selectedRequest = null;
            _selectedUnit = null;
            lblRequestInfo.Text = "Select a request...";
            lblUnitInfo.Text = "Select a compatible unit...";
            btnIssue.Enabled = false;

            _isBusy = false;
        }

        private async void dgvRequests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null || _isBusy)
            {
                return;
            }

            _isBusy = true;
            dgvUnits.DataSource = null;
            _selectedUnit = null;
            lblUnitInfo.Text = "Select a compatible unit...";
            btnIssue.Enabled = false;

            try
            {
                var reqId = (int)dgvRequests.CurrentRow.Cells["Id"].Value;
                _selectedRequest = await _dbContext.Requests.FindAsync(reqId);

                if (_selectedRequest != null)
                {
                    lblRequestInfo.Text = $"Request ID: {_selectedRequest.Id} ({_selectedRequest.BloodGroup})";
                    await LoadCompatibleUnits(_selectedRequest.BloodGroup);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting request: {ex.Message}");
            }
            finally
            {
                _isBusy = false;
            }
        }

        private async Task LoadCompatibleUnits(string? requiredBloodGroup)
        {
            var compatibleUnits = await _dbContext.BloodUnits
                .Where(bu => bu.Status == "Available" && bu.BloodGroup == requiredBloodGroup)
                .ToListAsync();

            dgvUnits.DataSource = compatibleUnits;
            dgvUnits.ClearSelection();
        }

        private void dgvUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null || _isBusy)
            {
                return;
            }

            var unitId = (int)dgvUnits.CurrentRow.Cells["Id"].Value;
            _selectedUnit = _dbContext.BloodUnits.Local.FirstOrDefault(bu => bu.Id == unitId);

            if (_selectedUnit == null)
            {
                _selectedUnit = _dbContext.BloodUnits.Find(unitId);
            }

            if (_selectedUnit != null)
            {
                lblUnitInfo.Text = $"Unit: {_selectedUnit.UnitCode} (Expires: {_selectedUnit.ExpiryDate:d})";
                btnIssue.Enabled = true;
            }
            else
            {
                lblUnitInfo.Text = "Select a compatible unit...";
                btnIssue.Enabled = false;
            }
        }

        private async void btnIssue_Click(object sender, EventArgs e)
        {
            if (_selectedRequest == null || _selectedUnit == null)
            {
                MessageBox.Show("You must select both a request and a compatible unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_isBusy) return;
            _isBusy = true;

            var strategy = _dbContext.Database.CreateExecutionStrategy();

            await strategy.ExecuteAsync(async () =>
            {
                using (var transaction = await _dbContext.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var issueRecord = new IssueRecord
                        {
                            UnitId = _selectedUnit.Id,
                            RequestId = _selectedRequest.Id,
                            IssuedByUsername = _userService.Username,
                            IssueDate = DateTime.UtcNow
                        };
                        _dbContext.IssueRecords.Add(issueRecord);

                        _selectedUnit.Status = "Issued";
                        _dbContext.BloodUnits.Update(_selectedUnit);

                        _selectedRequest.Status = "Completed";
                        _dbContext.Requests.Update(_selectedRequest);

                        await _dbContext.SaveChangesAsync();
                        await transaction.CommitAsync();

                        string logMessage = $"Issued Unit '{_selectedUnit.UnitCode}' to Request ID '{_selectedRequest.Id}'.";
                        await _auditService.LogActionAsync(logMessage);

                        MessageBox.Show(logMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await LoadPendingRequests();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"Error issuing unit: {ex.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        _isBusy = false;
                    }
                }
            });
        }
    }
}

