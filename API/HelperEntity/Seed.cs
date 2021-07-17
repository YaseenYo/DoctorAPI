using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DbContexts;
using API.Entities;

namespace API.HelperEntity
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Doctors.Any()) return;

            var patients = new List<Patient>
            {
                new Patient() 
                 {
                     Id = 1,
                     FirstName = "Maaz",
                     LastName = "Ahmed",
                     DateOfBirth = new DateTime(2002, 09, 06),
                     BloodGroup = "A+",
                     Address = "Banglore",
                     Mobile = 123456789,
                     Email = "mohammed17yo@gmail.com",
                     ImageUrl = "Kai/sai/mai",
                 },
                 new Patient()
                 {
                     Id = 2,
                     FirstName = "Yaseen",
                     LastName = "Ahmed",
                     DateOfBirth = new DateTime(2000, 08, 17),
                     BloodGroup = "B+",
                     Address = "Banglore",
                     Mobile = 123456789,
                     Email = "mohammed17yo@gmail.com",
                     ImageUrl = "Kai/sai/mai",
                 },
                 new Patient()
                 {
                     Id = 3,
                     FirstName = "Muiz",
                     LastName = "Ahmed",
                     DateOfBirth = new DateTime(2004, 11, 28),
                     BloodGroup = "A+",
                     Address = "Banglore",
                     Mobile = 123456789,
                     Email = "mohammed17yo@gmail.com",
                     ImageUrl = "Kai/sai/mai",
                 },
                 new Patient()
                 {
                     Id = 4,
                     FirstName = "Faizan",
                     LastName = "Ahmed",
                     DateOfBirth = new DateTime(2006, 08, 26),
                     BloodGroup = "A+",
                     Address = "Banglore",
                     Mobile = 123456789,
                     Email = "mohammed17yo@gmail.com",
                     ImageUrl = "Kai/sai/mai",
                 }
            };

            var doctors = new List<Doctor>{
                new Doctor()
                {
                    Id = 1,
                    Name = "Dr. Ruby Perrin",
                    Specialization = "Dental",
                    ImageUrl = "assets/img/doctors/doctor-thumb-01.jpg"
                },
                new Doctor()
                {
                    Id = 2,
                    Name = "Dr. Pawan L M",
                    Specialization = "Dental",
                    ImageUrl = "assets/img/doctors/doctor-thumb-02.jpg"
                },
                new Doctor()
                {
                    Id = 3,
                    Name = "Dr. Deborah Angel",
                    Specialization = "Cardiology",
                    ImageUrl = "assets/img/doctors/doctor-thumb-03.jpg"
                },
                new Doctor()
                {
                    Id = 4,
                    Name = "Dr. Sofia Brient",
                    Specialization = "Urology",
                    ImageUrl = "assets/img/doctors/doctor-thumb-04.jpg"
                },
                new Doctor()
                {
                    Id = 5,
                    Name = "Dr. Owais Gogi",
                    Specialization = "Ophthalmology",
                    ImageUrl = "assets/img/doctors/doctor-thumb-05.jpg"
                },
                new Doctor()
                {
                    Id = 6,
                    Name = "Dr. Katharine Berthold",
                    Specialization = "Orthopaedics",
                    ImageUrl = "assets/img/doctors/doctor-thumb-06.jpg"
                },
                new Doctor()
                {
                    Id = 7,
                    Name = "Dr. Linda Tobin",
                    Specialization = "Neurology",
                    ImageUrl = "assets/img/doctors/doctor-thumb-07.jpg"
                },
                new Doctor()
                {
                    Id = 8,
                    Name = "Dr. Mohammed Ali",
                    Specialization = "Dermatology",
                    ImageUrl = "assets/img/doctors/doctor-thumb-08.jpg"
                },
                new Doctor()
                {
                    Id = 9,
                    Name = "Dr. Muzafar Ahmed",
                    Specialization = "Dental",
                    ImageUrl = "assets/img/doctors/doctor-thumb-09.jpg"
                },
                new Doctor()
                {
                    Id = 10,
                    Name = "Dr. Olga Barlow",
                    Specialization = "Dental",
                    ImageUrl = "assets/img/doctors/doctor-thumb-10.jpg"
                },
                new Doctor()
                {
                    Id = 11,
                    Name = "Dr. Julia Washington",
                    Specialization = "Endocrinology",
                    ImageUrl = "assets/img/doctors/doctor-thumb-11.jpg"
                },
                new Doctor()
                {
                    Id = 12,
                    Name = "Dr. Muzammil Ahmed",
                    Specialization = "Otorhinolaryngology",
                    ImageUrl = "assets/img/doctors/doctor-thumb-12.jpg"
                }
            };

            var appointments = new List<Appointment>{
                new Appointment()
                {
                    Id = 1,
                    ApptDate = new DateTime(2021, 01, 09),
                    BookingDate = new DateTime(2021, 01, 08),
                    Status = Status.Pending,
                    DoctorId = 1,
                    PatientId = 1
                }
            };
            
            await context.Doctors.AddRangeAsync(doctors);
            await context.Patients.AddRangeAsync(patients);
            await context.Appointments.AddRangeAsync(appointments);
            await context.SaveChangesAsync();
        }
    }
}