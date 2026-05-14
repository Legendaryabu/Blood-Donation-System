using System.ComponentModel.DataAnnotations;

namespace BloodBankApp.Models
{
    public class Donor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }
        public string? Gender { get; set; }
        public string? BloodGroup { get; set; }  // e.g. A+, O-
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastDonationDate { get; set; }

        // Navigation property: A donor can have many donations
        public ICollection<Donation>? Donations { get; set; }
    }
}

