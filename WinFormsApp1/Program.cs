using BloodBankApp.Data;
using BloodBankApp.Forms;
using BloodBankApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace BloodBankApp
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder(args).Build();
            ServiceProvider = host.Services;

            try
            {
                using (var scope = ServiceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    dbContext.Database.Migrate();

                    DatabaseService.SeedAdminUser(dbContext);
                    DatabaseService.SeedSampleData(dbContext);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during database setup: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Run the application
            var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                string username = loginForm.EnteredUsername;

                var currentUserService = ServiceProvider.GetRequiredService<CurrentUserService>();
                currentUserService.Username = username;

                var mainForm = new MainForm(ServiceProvider, currentUserService);

                Application.Run(mainForm);
            }
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    // --- Database Context ---
                    string connectionString = "Server=localhost;Port=3306;Database=bloodbankdb;Uid=root;Pwd=;";
                    var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseMySql(connectionString, serverVersion,
                            mySqlOptions => mySqlOptions.EnableRetryOnFailure(
                                maxRetryCount: 5,
                                maxRetryDelay: TimeSpan.FromSeconds(30),
                                errorNumbersToAdd: null
                            )
                        ));

                    // --- Services ---
                    services.AddSingleton<CurrentUserService>();
                    services.AddTransient<AuthService>();
                    services.AddTransient<AuditService>();

                    services.AddTransient<LoginForm>();
                    services.AddTransient<MainForm>();
                    services.AddTransient<DonorForm>();
                    services.AddTransient<DonationForm>();
                    services.AddTransient<InventoryForm>();
                    services.AddTransient<RequestForm>();
                    services.AddTransient<IssueForm>();
                    services.AddTransient<ScreeningForm>();
                    services.AddTransient<AuditLogForm>();
                    services.AddTransient<ReportForm>();
                    services.AddTransient<DashboardForm>();
                    services.AddTransient<AboutForm>();
                });
    }
}

