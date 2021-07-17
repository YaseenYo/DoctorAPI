using API.DbContexts;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;
        public DoctorRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddPatient(string firstName, string lastName, string email, string bloodGroup, 
            string dateOfBirth, int mobile, string imgUrl, string address)
        {
            var newDate = dateOfBirth.Split('/');
            var dob = new DateTime(int.Parse(newDate[2]), int.Parse(newDate[1]), int.Parse(newDate[0]));
            var newPatient = new Patient()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                BloodGroup = bloodGroup,
                Mobile = mobile,
                DateOfBirth = dob,
                Email = email,
                ImageUrl = imgUrl
            };

            _context.Patients.Add(newPatient);
        }

        public void AddUserCredentials(string email, int password,int patientId)
        {
            var newUser = new UserCredentials
            {
                Email = email,
                PassWord = password,
                PatientId = patientId
            };
            _context.UserCredentials.Add(newUser);
        }

        public async Task<IEnumerable<Appointment>> GetAppointments(int Id)
        {
            return await _context.Appointments.Where(a => a.Patient.Id == Id).ToListAsync();
        }

        public async Task<Patient> GetPatient(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task<int> GetPatientIdByEmail(string email)
        {
            return await _context.UserCredentials.Where(u => u.Email == email).Select(x => x.PatientId).FirstAsync();
        }

        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<bool> GetUserCredentials(string email,int password)
        {
            var isUserRegistered = await _context.UserCredentials.AnyAsync(u => u.Email == email && u.PassWord == password);

            return isUserRegistered;

        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public async Task<int> GetPatientId()
        {
            return await _context.Patients.CountAsync();
        }
    }
}
