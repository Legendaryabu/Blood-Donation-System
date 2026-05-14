using BloodBankApp.Data;
using BloodBankApp.Models;
using BloodBankApp.Services;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class DonorForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly AuditService _auditService;
        private Donor? _selectedDonor;

        public DonorForm(AppDbContext dbContext, AuditService auditService)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _auditService = auditService;
        }

        private async void DonorForm_Load(object sender, EventArgs e)
        {
            await LoadDonors();
            ClearSelection();
        }

        private async Task LoadDonors()
        {
            var donors = await _dbContext.Donors.AsNoTracking().ToListAsync();
            dgvDonors.DataSource = donors;

            dgvDonors.ReadOnly = true;
            dgvDonors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvDonors.Columns["Id"] != null) dgvDonors.Columns["Id"].Width = 50;
            if (dgvDonors.Columns["BloodGroup"] != null) dgvDonors.Columns["BloodGroup"].Width = 70;
            if (dgvDonors.Columns["Donations"] != null) dgvDonors.Columns["Donations"].Visible = false;
        }

        private void ClearSelection()
        {
            dgvDonors.ClearSelection();
            gbDonorDetails.Enabled = false;
            btnDelete.Enabled = false;
            _selectedDonor = null;

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            dtpDOB.Value = DateTime.Now.AddYears(-20);
            cmbBloodGroup.SelectedIndex = -1;
        }

        private void dgvDonors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonors.CurrentRow == null)
            {
                ClearSelection();
                return;
            }

            var donorId = (int)dgvDonors.CurrentRow.Cells["Id"].Value;

            _selectedDonor = _dbContext.Donors.Find(donorId);

            if (_selectedDonor != null)
            {
                gbDonorDetails.Enabled = true;
                btnDelete.Enabled = true;

                txtFirstName.Text = _selectedDonor.FirstName;
                txtLastName.Text = _selectedDonor.LastName;
                txtPhone.Text = _selectedDonor.Phone;
                txtEmail.Text = _selectedDonor.Email;
                txtAddress.Text = _selectedDonor.Address;
                dtpDOB.Value = _selectedDonor.DOB ?? DateTime.Now.AddYears(-20);
                cmbBloodGroup.SelectedItem = _selectedDonor.BloodGroup;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearSelection();
            gbDonorDetails.Enabled = true;
            txtFirstName.Focus();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbBloodGroup.SelectedItem == null)
            {
                MessageBox.Show("Blood Group is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_selectedDonor == null)
                {
                    _selectedDonor = new Donor();
                    _dbContext.Donors.Add(_selectedDonor);
                }

                _selectedDonor.FirstName = txtFirstName.Text;
                _selectedDonor.LastName = txtLastName.Text;
                _selectedDonor.Phone = txtPhone.Text;
                _selectedDonor.Email = txtEmail.Text;
                _selectedDonor.Address = txtAddress.Text;
                _selectedDonor.DOB = dtpDOB.Value;
                _selectedDonor.BloodGroup = cmbBloodGroup.SelectedItem.ToString();

                await _dbContext.SaveChangesAsync();

                MessageBox.Show("Donor saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving donor: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await LoadDonors();
                ClearSelection();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDonor == null)
            {
                MessageBox.Show("No donor selected to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool hasDonations = await _dbContext.Donations.AnyAsync(d => d.DonorId == _selectedDonor.Id);
            if (hasDonations)
            {
                MessageBox.Show("This donor cannot be deleted because they have existing donation records.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you want to delete {_selectedDonor.FirstName} {_selectedDonor.LastName}?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _dbContext.Donors.Remove(_selectedDonor);
                    await _dbContext.SaveChangesAsync();

                    await _auditService.LogActionAsync($"Deleted Donor: {_selectedDonor.FirstName} {_selectedDonor.LastName} (ID: {_selectedDonor.Id})");

                    MessageBox.Show("Donor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting donor: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    await LoadDonors();
                    ClearSelection();
                }
            }
        }
    }
}

