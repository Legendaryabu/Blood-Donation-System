using BloodBankApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class AuditLogForm : Form
    {
        private readonly AppDbContext _dbContext;

        public AuditLogForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private async void AuditLogForm_Load(object sender, EventArgs e)
        {
            await LoadLogs();
        }

        private async Task LoadLogs()
        {
            try
            {
                var logs = await _dbContext.AuditLogs
                                .OrderByDescending(log => log.Timestamp)
                                .ToListAsync();

                dgvAuditLogs.DataSource = logs;

                if (dgvAuditLogs.Columns["Action"] != null)
                {
                    dgvAuditLogs.Columns["Action"].FillWeight = 200;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading audit logs: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

