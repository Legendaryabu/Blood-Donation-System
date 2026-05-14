using BloodBankApp.Data;
using BloodBankApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BloodBankApp.Services
{
    public static class DatabaseService
    {
        public static void SeedAdminUser(AppDbContext dbContext)
        {
            try
            {
                if (!dbContext.Users.Any(u => u.Username == "admin"))
                {
                    var authService = new AuthService();
                    var adminUser = new Models.User
                    {
                        Username = "admin",
                        PasswordHash = authService.HashPassword("admin123"),
                        Role = "Admin",
                        FullName = "System Administrator"
                    };
                    dbContext.Users.Add(adminUser);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while seeding the admin user: {ex.Message}");
            }
        }

        public static void SeedSampleData(AppDbContext dbContext)
        {
            try
            {
                if (dbContext.Donors.Any())
                {
                    return;
                }

                var donor1 = new Donor { FirstName = "Risla", LastName = "Nawal", DOB = new DateTime(2002, 1, 15), BloodGroup = "O+", Phone = "743629719", Email = "risla@example.com", Address = "123 Main St" };
                var donor2 = new Donor { FirstName = "Fathi", LastName = "Aysha", DOB = new DateTime(2000, 5, 20), BloodGroup = "A-", Phone = "742345678", Email = "aysha@example.com", Address = "456 Main Rd" };
                var donor3 = new Donor { FirstName = "Farhath", LastName = "Fathi", DOB = new DateTime(1999, 9, 10), BloodGroup = "B+", Phone = "742345678", Email = "farhath@example.com", Address = "14 Main st" };
                var donor4 = new Donor { FirstName = "Nifla", LastName = "Kiaser", DOB = new DateTime(2004, 3, 30), BloodGroup = "AB+", Phone = "742345678", Email = "nifla@example.com", Address = "101 beach rd" };
                var donor5 = new Donor { FirstName = "Riskan", LastName = "Ahamed", DOB = new DateTime(2007, 7, 22), BloodGroup = "O-", Phone = "742345678", Email = "riskan@example.com", Address = "202 newavanue" };

                dbContext.Donors.AddRange(donor1, donor2, donor3, donor4, donor5);
                dbContext.SaveChanges();

                var patient1 = new Patient { FirstName = "Fazal", LastName = "Ilmi", HospitalNumber = "HN-001" };
                var patient2 = new Patient { FirstName = "Ayman", LastName = "Reeza", HospitalNumber = "HN-002" };
                var patient3 = new Patient { FirstName = "Neers", LastName = "Sheeras", HospitalNumber = "HN-003" };

                dbContext.Patients.AddRange(patient1, patient2, patient3);
                dbContext.SaveChanges();

                var donation1 = new Donation { DonorId = donor1.Id, DonationDate = DateTime.UtcNow.AddDays(-10), VolumeMl = 450, BloodGroup = "O+", Rh = "Pos", Status = "Completed" };
                var donation2 = new Donation { DonorId = donor2.Id, DonationDate = DateTime.UtcNow.AddDays(-15), VolumeMl = 450, BloodGroup = "A-", Rh = "Neg", Status = "Completed" };
                var donation3 = new Donation { DonorId = donor3.Id, DonationDate = DateTime.UtcNow.AddDays(-5), VolumeMl = 450, BloodGroup = "B+", Rh = "Pos", Status = "Collected" };
                var donation4 = new Donation { DonorId = donor4.Id, DonationDate = DateTime.UtcNow.AddDays(-20), VolumeMl = 450, BloodGroup = "AB+", Rh = "Pos", Status = "Completed" };
                var donation5 = new Donation { DonorId = donor5.Id, DonationDate = DateTime.UtcNow.AddDays(-8), VolumeMl = 450, BloodGroup = "O-", Rh = "Neg", Status = "Collected" };
                var donation6 = new Donation { DonorId = donor1.Id, DonationDate = DateTime.UtcNow.AddDays(-2), VolumeMl = 450, BloodGroup = "O+", Rh = "Pos", Status = "Collected" };

                dbContext.Donations.AddRange(donation1, donation2, donation3, donation4, donation5, donation6);
                dbContext.SaveChanges();

                var test1 = new Test { DonationId = donation1.Id, HB = 14.0, HIVResult = "Negative", HBsAgResult = "Negative", HCVResult = "Negative", SyphilisResult = "Negative" };
                var test2 = new Test { DonationId = donation2.Id, HB = 13.5, HIVResult = "Negative", HBsAgResult = "Negative", HCVResult = "Negative", SyphilisResult = "Negative" };
                var test4 = new Test { DonationId = donation4.Id, HB = 14.2, HIVResult = "Negative", HBsAgResult = "Negative", HCVResult = "Negative", SyphilisResult = "Negative" };

                dbContext.Tests.AddRange(test1, test2, test4);
                dbContext.SaveChanges();

                var unit1 = new BloodUnit { DonationId = donation1.Id, UnitCode = "U-000001", Component = "Whole Blood", BloodGroup = "O+", Rh = "Pos", CollectedDate = donation1.DonationDate, ExpiryDate = donation1.DonationDate.AddDays(35), Status = "Available" };
                var unit2 = new BloodUnit { DonationId = donation2.Id, UnitCode = "U-000002", Component = "Whole Blood", BloodGroup = "A-", Rh = "Neg", CollectedDate = donation2.DonationDate, ExpiryDate = donation2.DonationDate.AddDays(35), Status = "Available" };
                var unit3 = new BloodUnit { DonationId = donation3.Id, UnitCode = "U-000003", Component = "Platelets", BloodGroup = "B+", Rh = "Pos", CollectedDate = donation3.DonationDate, ExpiryDate = donation3.DonationDate.AddDays(5), Status = "InInventory" };
                var unit4 = new BloodUnit { DonationId = donation4.Id, UnitCode = "U-000004", Component = "Plasma", BloodGroup = "AB+", Rh = "Pos", CollectedDate = donation4.DonationDate, ExpiryDate = donation4.DonationDate.AddDays(365), Status = "Issued" };
                var unit5 = new BloodUnit { DonationId = donation5.Id, UnitCode = "U-000005", Component = "Whole Blood", BloodGroup = "O-", Rh = "Neg", CollectedDate = donation5.DonationDate, ExpiryDate = donation5.DonationDate.AddDays(35), Status = "InInventory" };
                var unit6 = new BloodUnit { DonationId = donor1.Id, UnitCode = "U-000006", Component = "Whole Blood", BloodGroup = "O+", Rh = "Pos", CollectedDate = donation6.DonationDate, ExpiryDate = donation6.DonationDate.AddDays(35), Status = "InInventory" };

                dbContext.BloodUnits.AddRange(unit1, unit2, unit3, unit4, unit5, unit6);
                dbContext.SaveChanges();

                var request1 = new Models.Request { PatientId = patient1.Id, RequestDate = DateTime.UtcNow.AddDays(-1), BloodGroup = "A-", UnitsRequired = 1, Status = "Pending" };
                var request2 = new Models.Request { PatientId = patient2.Id, RequestDate = DateTime.UtcNow.AddDays(-2), BloodGroup = "O+", UnitsRequired = 2, Status = "Pending" };
                var request3 = new Models.Request { PatientId = patient3.Id, RequestDate = DateTime.UtcNow.AddDays(-10), BloodGroup = "AB+", UnitsRequired = 1, Status = "Completed" };

                dbContext.Requests.AddRange(request1, request2, request3);
                dbContext.SaveChanges();

                var issue1 = new IssueRecord { UnitId = unit4.Id, RequestId = request3.Id, IssuedByUsername = "admin", IssueDate = DateTime.UtcNow.AddDays(-10) };

                dbContext.IssueRecords.Add(issue1);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while seeding sample data: {ex.Message}");
            }
        }
    }
}

