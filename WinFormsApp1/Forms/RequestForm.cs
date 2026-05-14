using BloodBankApp.Data;
using BloodBankApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBankApp.Forms
{
    public partial class RequestForm : Form
    {
        private readonly AppDbContext _dbContext;
        private Patient? _selectedPatient;
        private bool _isBusy = false;

        public RequestForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private async void RequestForm_Load(object sender, EventArgs e)
        {
            await LoadPatients();
            await LoadPendingRequests();
        }

        private async Task LoadPatients()
        {
            if (_isBusy) return;
            _isBusy = true;
            try
            {
                dgvPatients.DataSource = await _dbContext.Patients.AsNoTracking().ToListAsync();
                dgvPatients.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isBusy = false;
            }
        }

        private async void btnSavePatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtHospitalNumber.Text))
            {
                MessageBox.Show("First Name and Hospital Number are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newPatient = new Patient
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    HospitalNumber = txtHospitalNumber.Text
                };

                _dbContext.Patients.Add(newPatient);
                await _dbContext.SaveChangesAsync();

                MessageBox.Show("Patient saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtHospitalNumber.Text = "";

                await LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patient: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null)
            {
                _selectedPatient = null;
                gbCreateRequest.Enabled = false;
                lblPatientInfo.Text = "No Patient Selected...";
                return;
            }

            var patientId = (int)dgvPatients.CurrentRow.Cells["Id"].Value;
            _selectedPatient = _dbContext.Patients.Find(patientId);

            if (_selectedPatient != null)
            {
                lblPatientInfo.Text = $"Selected: {_selectedPatient.FirstName} {_selectedPatient.LastName} (ID: {_selectedPatient.Id})";
                gbCreateRequest.Enabled = true;
            }
        }

        private async void btnCreateRequest_Click(object sender, EventArgs e)
        {
            if (_selectedPatient == null)
            {
                MessageBox.Show("Please select a patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbBloodGroup.SelectedItem == null)
            {
                MessageBox.Show("Please select a blood group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newRequest = new Models.Request
                {
                    PatientId = _selectedPatient.Id,
                    RequestDate = DateTime.UtcNow,
                    BloodGroup = cmbBloodGroup.SelectedItem.ToString(),
                    UnitsRequired = (int)numUnits.Value,
                    Status = "Pending"
                };

                _dbContext.Requests.Add(newRequest);
                await _dbContext.SaveChangesAsync();

                MessageBox.Show("Blood request created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvPatients.ClearSelection();
                cmbBloodGroup.SelectedIndex = -1;
                numUnits.Value = 1;

                await LoadPendingRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating request: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task LoadPendingRequests()
        {
            if (_isBusy) return;
            _isBusy = true;
            try
            {
                var pendingRequests = await _dbContext.Requests
                    .Where(r => r.Status == "Pending")
                    .Include(r => r.Patient)
                    .Select(r => new
                    {
                        r.Id,
                        PatientName = (r.Patient == null) ? "N/A" : (r.Patient.FirstName + " " + r.Patient.LastName),
                        r.BloodGroup,
                        r.UnitsRequired,
                        r.RequestDate,
                        r.Status
                    })
                    .ToListAsync();

                dgvRequests.DataSource = pendingRequests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pending requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isBusy = false;
            }
        }

        private async void tabRequests_Enter(object sender, EventArgs e)
        {
            await LoadPatients();
            await LoadPendingRequests();
        }
    }
}

