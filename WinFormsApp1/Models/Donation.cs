    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankApp.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public Donor Donor { get; set; } = null!;
        public DateTime DonationDate { get; set; }
        public int VolumeMl { get; set; }
        public string? BloodGroup { get; set; }
        public string? Rh { get; set; }
        public string? Status { get; set; } // e.g. Collected, Processed, Rejected
        public ICollection<Test>? Tests { get; set; }
        public ICollection<BloodUnit>? Units { get; set; }
    }
}
