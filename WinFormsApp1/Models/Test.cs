    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankApp.Models
{
    public class Test
    {
        public int Id { get; set; }
        public int DonationId { get; set; }
        public Donation Donation { get; set; } = null!;
        public double? HB { get; set; } // Hemoglobin
        public string? HIVResult { get; set; }
        public string? HBsAgResult { get; set; } // Hepatitis B
        public string? HCVResult { get; set; } // Hepatitis C
        public string? SyphilisResult { get; set; }
        public string? Notes { get; set; }
    }
}
