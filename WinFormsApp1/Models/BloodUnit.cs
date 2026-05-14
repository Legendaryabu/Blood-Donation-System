using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankApp.Models
{
    public class BloodUnit
    {
        public int Id { get; set; }
        public int? DonationId { get; set; }
        public Donation? Donation { get; set; }
        public string UnitCode { get; set; } = null!; // unique code
        public string Component { get; set; } = "WholeBlood"; // WholeBlood, Plasma, Platelets
        public string? BloodGroup { get; set; }
        public string? Rh { get; set; }
        public DateTime CollectedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; } = "InInventory"; // InInventory, Issued, Discarded
        public IssueRecord? IssueRecord { get; set; }
    }
}
