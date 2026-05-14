using BloodBankApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly AppDbContext _dbContext;

        public DashboardForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWatermark.SendToBack();
            await LoadDashboardStats();
            CenterControls();
        }

        private async Task LoadDashboardStats()
        {
            try
            {
                var availableUnits = await _dbContext.BloodUnits
                    .Where(b => b.Status == "Available")
                    .CountAsync();
                lblAvailableUnits.Text = availableUnits.ToString();

                var pendingRequests = await _dbContext.Requests
                    .Where(r => r.Status == "Pending")
                    .CountAsync();
                lblPendingRequests.Text = pendingRequests.ToString();

                var lowInventoryGroups = await _dbContext.BloodUnits
                    .Where(b => b.Status == "Available")
                    .GroupBy(b => b.BloodGroup)
                    .Select(g => new { BloodGroup = g.Key, Count = g.Count() })
                    .Where(g => g.Count < 3)
                    .CountAsync();

                lblLowInventory.Text = lowInventoryGroups.ToString();

                if (lowInventoryGroups > 0)
                {
                    lblLowInventory.ForeColor = Color.FromArgb(220, 53, 69);
                }
                else
                {
                    lblLowInventory.ForeColor = Color.FromArgb(2, 136, 209);
                }


                var recentRequests = await _dbContext.Requests
                    .Where(r => r.Status == "Pending")
                    .Include(r => r.Patient)
                    .OrderByDescending(r => r.RequestDate)
                    .Take(5)
                    .Select(r => new
                    {
                        r.Id,
                        PatientName = (r.Patient == null) ? "N/A" : (r.Patient.FirstName + " " + r.Patient.LastName),
                        r.BloodGroup,
                        r.UnitsRequired,
                        r.RequestDate
                    })
                    .ToListAsync();

                dgvPendingRequests.DataSource = recentRequests;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDashboardStats();
        }

        private void btnRecordDonation_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MainForm)?.OpenDonationForm();
        }

        private void btnIssueBlood_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MainForm)?.OpenIssueForm();
        }

        private void btnManageDonors_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MainForm)?.OpenDonorForm();
        }

        private void btnBloodInventory_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MainForm)?.OpenInventoryForm();
        }

        private void DashboardForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int totalButtonWidth = btnRecordDonation.Width + btnIssueBlood.Width + btnManageDonors.Width + btnBloodInventory.Width + (3 * 10);
            int startX = (groupBox2.Width - totalButtonWidth) / 2;

            if (startX < 0) startX = 0;

            btnRecordDonation.Location = new Point(startX, btnRecordDonation.Location.Y);
            btnIssueBlood.Location = new Point(startX + btnRecordDonation.Width + 10, btnIssueBlood.Location.Y);
            btnManageDonors.Location = new Point(startX + btnRecordDonation.Width + btnIssueBlood.Width + 20, btnManageDonors.Location.Y);
            btnBloodInventory.Location = new Point(startX + btnRecordDonation.Width + btnIssueBlood.Width + btnManageDonors.Width + 30, btnBloodInventory.Location.Y);

            int totalPanelWidth = panel1.Width + panel2.Width + panel3.Width + (2 * 16);
            int panelStartX = (this.ClientSize.Width - totalPanelWidth) / 2;

            if (panelStartX < 0) panelStartX = 0;

            panel1.Location = new Point(panelStartX, panel1.Location.Y);
            panel2.Location = new Point(panelStartX + panel1.Width + 16, panel2.Location.Y);
            panel3.Location = new Point(panelStartX + panel1.Width + panel2.Width + 32, panel3.Location.Y);
        }
    }
}

