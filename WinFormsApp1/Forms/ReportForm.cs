using BloodBankApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class ReportForm : Form
    {
        private readonly AppDbContext _dbContext;
        private bool _isBusy = false;

        public ReportForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private async void ReportForm_Load(object sender, EventArgs e)
        {
            dtpHistory.Value = DateTime.Now.AddDays(-30);
            await LoadInventoryReport();
        }

        private async Task LoadInventoryReport()
        {
            if (_isBusy) return;
            _isBusy = true;

            try
            {
                var inventorySummary = await _dbContext.BloodUnits
                    .Where(bu => bu.Status == "Available")
                    .GroupBy(bu => bu.BloodGroup)
                    .Select(g => new
                    {
                        BloodGroup = g.Key,
                        TotalUnits = g.Count()
                    })
                    .OrderBy(r => r.BloodGroup)
                    .ToListAsync();

                dgvInventorySummary.DataSource = inventorySummary;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isBusy = false;
            }
        }

        private async Task LoadDonationHistory()
        {
            if (_isBusy) return;
            _isBusy = true;

            try
            {
                var filterDate = dtpHistory.Value.Date;

                var donationData = await _dbContext.Donations
                    .Where(d => d.DonationDate >= filterDate)
                    .Include(d => d.Donor)
                    .OrderByDescending(d => d.DonationDate)
                    .ToListAsync();

                var donationHistory = donationData.Select(d => new
                {
                    d.Id,
                    DonationDate = d.DonationDate.ToShortDateString(),
                    DonorName = (d.Donor == null) ? "N/A" : (d.Donor.FirstName + " " + d.Donor.LastName),
                    d.BloodGroup,
                    d.VolumeMl,
                    d.Status
                })
                .ToList();

                dgvDonationHistory.DataSource = donationHistory;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading donation history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isBusy = false;
            }
        }

        private async void tabInventory_Enter(object sender, EventArgs e)
        {
            await LoadInventoryReport();
        }

        private async void tabHistory_Enter(object sender, EventArgs e)
        {
            await LoadDonationHistory();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDonationHistory();
        }
    }
}

