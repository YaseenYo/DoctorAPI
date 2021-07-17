using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class UserCredentials
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public int PassWord { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
