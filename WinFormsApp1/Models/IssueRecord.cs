namespace BloodBankApp.Models
{
    public class IssueRecord
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public BloodUnit? Unit { get; set; }

        public int RequestId { get; set; }
        public Request? Request { get; set; }

        public string? IssuedByUsername { get; set; } // <-- THIS WAS MISSING
        public DateTime IssueDate { get; set; }
    }
}

