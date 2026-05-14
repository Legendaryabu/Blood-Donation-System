using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankApp.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
        public int? RequestedByUserId { get; set; }
        public User? RequestedByUser { get; set; }
        public DateTime RequestDate { get; set; }
        public string? BloodGroup { get; set; }
        public int UnitsRequired { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Fulfilled, Cancelled
        public ICollection<IssueRecord>? IssueRecords { get; set; }
    }
}
