using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string BloodGroup { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int Mobile { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<Appointment> Appointments { get; set; } =
            new List<Appointment>();
    }
}
