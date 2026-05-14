using BloodBankApp.Models;
using Microsoft.EntityFrameworkCore;
using User = BloodBankApp.Models.User;
using Request = BloodBankApp.Models.Request;

namespace BloodBankApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<BloodUnit> BloodUnits { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<IssueRecord> IssueRecords { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<BloodUnit>().HasIndex(u => u.UnitCode).IsUnique();
            modelBuilder.Entity<Patient>().HasIndex(p => p.HospitalNumber).IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}

