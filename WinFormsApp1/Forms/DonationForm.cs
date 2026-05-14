using BloodBankApp.Data;
using BloodBankApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class DonationForm : Form
    {
        private readonly AppDbContext _dbContext;
        private Donor? _selectedDonor;

        public DonationForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void DonationForm_Load(object sender, EventArgs e)
        {
            LoadDonors();
            SetupComboBoxes();
            UpdateExpiryDate();
        }

        private void SetupComboBoxes()
        {
            cmbComponent.Items.AddRange(new string[] { "Whole Blood", "Platelets", "Plasma" });
            cmbComponent.SelectedIndex = 0;
        }

        private async void LoadDonors(string? searchTerm = null)
        {
            var query = _dbContext.Donors.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(d => (d.FirstName != null && d.FirstName.Contains(searchTerm)) ||
                                         (d.LastName != null && d.LastName.Contains(searchTerm)) ||
                                         d.Id.ToString() == searchTerm);
            }

            dgvDonors.DataSource = await query.OrderBy(d => d.LastName).ToListAsync();

            dgvDonors.ReadOnly = true;
            dgvDonors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvDonors.Columns["Id"] != null) dgvDonors.Columns["Id"].Width = 50;
            if (dgvDonors.Columns["FirstName"] != null) dgvDonors.Columns["FirstName"].Width = 120;
            if (dgvDonors.Columns["LastName"] != null) dgvDonors.Columns["LastName"].Width = 120;
            if (dgvDonors.Columns["BloodGroup"] != null) dgvDonors.Columns["BloodGroup"].Width = 70;
            if (dgvDonors.Columns["Phone"] != null) dgvDonors.Columns["Phone"].Width = 100;
            if (dgvDonors.Columns["Donations"] != null) dgvDonors.Columns["Donations"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDonors(txtSearch.Text);
        }

        private void dgvDonors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonors.CurrentRow == null)
            {
                gbDonationDetails.Enabled = false;
                _selectedDonor = null;
                lblDonorInfo.Text = "No Donor Selected...";
                return;
            }

            var donorId = (int)dgvDonors.CurrentRow.Cells["Id"].Value;
            _selectedDonor = _dbContext.Donors.Find(donorId);

            if (_selectedDonor != null)
            {
                lblDonorInfo.Text = $"Selected Donor: {_selectedDonor.FirstName} {_selectedDonor.LastName} (ID: {_selectedDonor.Id}, Blood: {_selectedDonor.BloodGroup})";
                gbDonationDetails.Enabled = true;
            }
        }

        private void dtpDonationDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateExpiryDate();
        }

        private void UpdateExpiryDate()
        {
            dtpExpiryDate.Value = dtpDonationDate.Value.AddDays(35);
        }

        private async void btnSaveDonation_Click(object sender, EventArgs e)
        {
            if (_selectedDonor == null)
            {
                MessageBox.Show("Please select a donor first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(_selectedDonor.BloodGroup))
            {
                MessageBox.Show("The selected donor does not have a blood group set. Please update the donor first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the execution strategy
            var strategy = _dbContext.Database.CreateExecutionStrategy();

            // Execute the transaction within the strategy
            await strategy.ExecuteAsync(async () =>
            {
                using (var transaction = await _dbContext.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var newDonation = new Donation
                        {
                            DonorId = _selectedDonor.Id,
                            DonationDate = dtpDonationDate.Value,
                            VolumeMl = (int)numVolume.Value,
                            BloodGroup = _selectedDonor.BloodGroup,
                            Rh = _selectedDonor.BloodGroup.EndsWith("+") ? "Pos" : "Neg",
                            Status = "Collected"
                        };
                        _dbContext.Donations.Add(newDonation);
                        await _dbContext.SaveChangesAsync();

                        var newUnit = new BloodUnit
                        {
                            DonationId = newDonation.Id,
                            UnitCode = $"U-{DateTime.Now.Ticks}",
                            Component = cmbComponent.SelectedItem!.ToString()!,
                            BloodGroup = _selectedDonor.BloodGroup,
                            Rh = newDonation.Rh,
                            CollectedDate = newDonation.DonationDate,
                            ExpiryDate = dtpExpiryDate.Value,
                            Status = "InInventory"
                        };
                        _dbContext.BloodUnits.Add(newUnit);

                        _selectedDonor.LastDonationDate = newDonation.DonationDate;
                        _dbContext.Donors.Update(_selectedDonor);

                        await _dbContext.SaveChangesAsync();
                        await transaction.CommitAsync();

                        MessageBox.Show($"Donation and Blood Unit (Code: {newUnit.UnitCode}) created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDonors();
                        gbDonationDetails.Enabled = false;
                        _selectedDonor = null;
                        lblDonorInfo.Text = "No Donor Selected...";
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            });
        }
    }
}

