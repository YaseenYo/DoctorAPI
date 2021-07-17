using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public DateTime ApptDate { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public Status Status { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }

    public enum Status
    {
        Confirm,
        Cancelled,
        Pending
    }
}
