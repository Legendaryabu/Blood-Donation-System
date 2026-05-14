using BloodBankApp.Data;
using BloodBankApp.Services;
using System.Drawing;

namespace BloodBankApp
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly AuthService _authService;

        public string EnteredUsername { get; private set; } = string.Empty;

        public LoginForm(AppDbContext dbContext, AuthService authService)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _authService = authService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = _dbContext.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_authService.VerifyPassword(password, user.PasswordHash))
            {
                this.EnteredUsername = user.Username;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

