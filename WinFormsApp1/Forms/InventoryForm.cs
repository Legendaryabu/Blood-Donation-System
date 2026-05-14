using BloodBankApp.Data;
using BloodBankApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class InventoryForm : Form
    {
        private readonly AppDbContext _dbContext;

        public InventoryForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            await LoadInventory();
            SetupFilters();
        }

        private void SetupFilters()
        {
            cmbBloodGroup.Items.Add("All");
            cmbBloodGroup.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            cmbBloodGroup.SelectedIndex = 0;

            cmbComponent.Items.Add("All");
            cmbComponent.Items.AddRange(new object[] { "Whole Blood", "Platelets", "Plasma" });
            cmbComponent.SelectedIndex = 0;
        }

        private async Task LoadInventory(string? bloodGroup = "All", string? component = "All")
        {
            var query = _dbContext.BloodUnits
                .Include(bu => bu.Donation)
                    .ThenInclude(d => d!.Donor)
                .AsQueryable();

            if (bloodGroup != null && bloodGroup != "All")
            {
                query = query.Where(bu => bu.BloodGroup == bloodGroup);
            }

            if (component != null && component != "All")
            {
                query = query.Where(bu => bu.Component == component);
            }

            var inventory = await query
                .Select(bu => new
                {
                    bu.Id,
                    bu.UnitCode,
                    bu.BloodGroup,
                    bu.Component,
                    DonorName = (bu.Donation != null && bu.Donation.Donor != null)
                                ? (bu.Donation.Donor.FirstName + " " + bu.Donation.Donor.LastName)
                                : "N/A",
                    bu.CollectedDate,
                    bu.ExpiryDate,
                    bu.Status
                })
                .OrderBy(bu => bu.ExpiryDate)
                .ToListAsync();

            dgvInventory.DataSource = inventory;

            if (dgvInventory.Columns["Id"] != null) dgvInventory.Columns["Id"].Width = 50;
            if (dgvInventory.Columns["UnitCode"] != null) dgvInventory.Columns["UnitCode"].Width = 120;
        }

        private async void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string? bloodGroup = cmbBloodGroup.SelectedItem?.ToString();
            string? component = cmbComponent.SelectedItem?.ToString();
            await LoadInventory(bloodGroup, component);
        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbBloodGroup.SelectedIndex = 0;
            cmbComponent.SelectedIndex = 0;
            await LoadInventory();
        }
    }
}

