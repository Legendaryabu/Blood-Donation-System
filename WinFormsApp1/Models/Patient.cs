using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string HospitalNumber { get; set; } = null!; // Unique Hospital ID
        public ICollection<Request>? Requests { get; set; }
    }
}
