using BloodBankApp.Forms;
using BloodBankApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using BloodBankApp.Helpers;

namespace BloodBankApp
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly CurrentUserService _userService;

        public MainForm(IServiceProvider serviceProvider, CurrentUserService userService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = userService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserStatus.Text = $"User: {_userService.Username}";

            menuStrip1.Renderer = new MenuRenderer();

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.FromArgb(245, 245, 245);
                }
            }

            OpenDashboardForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void OpenDashboardForm()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is DashboardForm)
                {
                    form.Activate();
                    return;
                }
            }
            var dashboard = _serviceProvider.GetRequiredService<DashboardForm>();
            dashboard.MdiParent = this;
            dashboard.WindowState = FormWindowState.Maximized;
            dashboard.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDashboardForm();
        }

        public void OpenDonorForm()
        {
            var donorForm = _serviceProvider.GetRequiredService<DonorForm>();
            donorForm.MdiParent = this;
            donorForm.Show();
        }

        private void manageDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDonorForm();
        }

        public void OpenDonationForm()
        {
            var donationForm = _serviceProvider.GetRequiredService<DonationForm>();
            donationForm.MdiParent = this;
            donationForm.Show();
        }

        private void recordDonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDonationForm();
        }

        public void OpenInventoryForm()
        {
            var inventoryForm = _serviceProvider.GetRequiredService<InventoryForm>();
            inventoryForm.MdiParent = this;
            inventoryForm.Show();
        }

        private void bloodInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenInventoryForm();
        }

        public void OpenRequestForm()
        {
            var requestForm = _serviceProvider.GetRequiredService<RequestForm>();
            requestForm.MdiParent = this;
            requestForm.Show();
        }

        private void manageRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRequestForm();
        }

        public void OpenIssueForm()
        {
            var issueForm = _serviceProvider.GetRequiredService<IssueForm>();
            issueForm.MdiParent = this;
            issueForm.Show();
        }

        private void issueBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenIssueForm();
        }

        public void OpenScreeningForm()
        {
            var screeningForm = _serviceProvider.GetRequiredService<ScreeningForm>();
            screeningForm.MdiParent = this;
            screeningForm.Show();
        }

        private void screeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenScreeningForm();
        }

        public void OpenAuditLogForm()
        {
            var auditForm = _serviceProvider.GetRequiredService<AuditLogForm>();
            auditForm.MdiParent = this;
            auditForm.Show();
        }

        private void auditLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAuditLogForm();
        }

        public void OpenReportForm()
        {
            var reportForm = _serviceProvider.GetRequiredService<ReportForm>();
            reportForm.MdiParent = this;
            reportForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReportForm();
        }

        public void OpenAboutForm()
        {
            var aboutForm = _serviceProvider.GetRequiredService<AboutForm>();
            aboutForm.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAboutForm();
        }
    }
}

