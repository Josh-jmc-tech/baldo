using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public int CarYear { get; set; }

        public bool HasDUI { get; set; }

        public int SpeedingTickets { get; set; }

        public bool FullCoverage { get; set; }
    }
}