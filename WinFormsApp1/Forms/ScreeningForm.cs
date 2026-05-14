using BloodBankApp.Data;
using BloodBankApp.Models;
using BloodBankApp.Services;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class ScreeningForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly AuditService _auditService;
        private Models.BloodUnit? _selectedUnit;
        private bool _isBusy = false;

        public ScreeningForm(AppDbContext dbContext, AuditService auditService)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _auditService = auditService;
        }

        private async void ScreeningForm_Load(object sender, EventArgs e)
        {
            await LoadPendingUnits();
            SetDefaults();
        }

        private void SetDefaults()
        {
            numHB.Value = 13.0m;
            cmbHIV.SelectedIndex = 0;
            cmbHBsAg.SelectedIndex = 0;
            cmbHCV.SelectedIndex = 0;
            cmbSyphilis.SelectedIndex = 0;
        }

        private async Task LoadPendingUnits()
        {
            _isBusy = true;
            var pendingUnits = await _dbContext.BloodUnits
                .Where(bu => bu.Status == "InInventory")
                .Include(bu => bu.Donation)
                    .ThenInclude(d => d!.Donor)
                .Select(bu => new
                {
                    bu.Id,
                    bu.UnitCode,
                    bu.BloodGroup,
                    bu.Component,

                    DonorName = (bu.Donation != null && bu.Donation.Donor != null)
                                ? (bu.Donation.Donor.FirstName + " " + bu.Donation.Donor.LastName)
                                : "N/A",

                    bu.CollectedDate
                })
                .ToListAsync();

            dgvPendingUnits.DataSource = pendingUnits;
            dgvPendingUnits.ClearSelection();

            groupBox2.Enabled = false;
            btnPassUnit.Enabled = false;
            btnFailUnit.Enabled = false;
            lblSelectedUnit.Text = "No Unit Selected...";
            _selectedUnit = null;

            _isBusy = false;
        }

        private async void dgvPendingUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPendingUnits.CurrentRow == null || _isBusy)
            {
                return;
            }

            _isBusy = true;

            try
            {
                var unitId = (int)dgvPendingUnits.CurrentRow.Cells["Id"].Value;
                _selectedUnit = await _dbContext.BloodUnits
                                        .Include(bu => bu.Donation)
                                        .FirstOrDefaultAsync(bu => bu.Id == unitId);

                if (_selectedUnit != null)
                {
                    lblSelectedUnit.Text = $"Unit Code: {_selectedUnit.UnitCode} (Donation ID: {_selectedUnit.DonationId})";
                    groupBox2.Enabled = true;
                    btnPassUnit.Enabled = true;
                    btnFailUnit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting unit: {ex.Message}");
            }
            finally
            {
                _isBusy = false;
            }
        }

        private async void btnPassUnit_Click(object sender, EventArgs e)
        {
            SetDefaults();
            await SaveScreeningResults("Available");
        }

        private async void btnFailUnit_Click(object sender, EventArgs e)
        {
            if (cmbHIV.SelectedIndex == 0 && cmbHBsAg.SelectedIndex == 0 && cmbHCV.SelectedIndex == 0 && cmbSyphilis.SelectedIndex == 0)
            {
                MessageBox.Show("To fail a unit, at least one test (HIV, HBsAg, HCV, Syphilis) must be set to 'Positive'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await SaveScreeningResults("Discarded");
        }

        private async Task SaveScreeningResults(string newUnitStatus)
        {
            if (_selectedUnit == null || _selectedUnit.DonationId == null)
            {
                MessageBox.Show("Invalid unit selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        var testRecord = new Test
                        {
                            DonationId = (int)_selectedUnit.DonationId,
                            HB = (double)numHB.Value,

                            HIVResult = cmbHIV.SelectedItem!.ToString(),
                            HBsAgResult = cmbHBsAg.SelectedItem!.ToString(),
                            HCVResult = cmbHCV.SelectedItem!.ToString(),
                            SyphilisResult = cmbSyphilis.SelectedItem!.ToString(),

                            Notes = txtNotes.Text
                        };
                        _dbContext.Tests.Add(testRecord);

                        _selectedUnit.Status = newUnitStatus;
                        _dbContext.BloodUnits.Update(_selectedUnit);

                        await _dbContext.SaveChangesAsync();
                        await transaction.CommitAsync();

                        string logMessage = $"Unit {_selectedUnit.UnitCode} screened. New status: {newUnitStatus}";
                        await _auditService.LogActionAsync(logMessage);

                        MessageBox.Show(logMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await LoadPendingUnits();
                        SetDefaults();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"Error saving results: {ex.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

