using BloodBankApp.Data;
using BloodBankApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankApp.Services
{
    public class AuditService
    {
        private readonly AppDbContext _dbContext;
        private readonly CurrentUserService _currentUserService;

        // We inject both the DbContext and the user service
        public AuditService(AppDbContext dbContext, CurrentUserService currentUserService)
        {
            _dbContext = dbContext;
            _currentUserService = currentUserService;
        }

        /// <summary>
        /// Asynchronously logs a user action to the database.
        /// </summary>
        /// <param name="action">The description of the action being logged.</param>

        // --- THIS IS THE FIX ---
        // Renamed from LogAction to LogActionAsync
        public async Task LogActionAsync(string action)
        {
            // Get the current user, or default to "System" if somehow unavailable
            var username = _currentUserService.Username ?? "System";

            try
            {
                var logEntry = new AuditLog
                {
                    Timestamp = DateTime.UtcNow,
                    Action = action,
                    Username = username // Use the new Username property
                };

                _dbContext.AuditLogs.Add(logEntry);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // In a real app, you'd log this error to a file,
                // but we don't want to crash the main application.
                Console.WriteLine($"Failed to write to audit log: {ex.Message}");
            }
        }
    }
}

