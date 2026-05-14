namespace BloodBankApp.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string? Username { get; set; } // <-- THIS WAS MISSING
        public string? Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Details { get; set; }
    }
}

