using API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Patient>> GetPatients();
        Task<IEnumerable<Appointment>> GetAppointments(int Id);
        Task<bool> GetUserCredentials(string email,int password);
        Task<int> GetPatientIdByEmail(string email);
        Task<Patient> GetPatient(int id);
        Task<bool> SaveAsync();
        void AddUserCredentials(string email, int password,int patientId);
        void AddPatient(string firstName, string lastName, string email, string bloodGroup,
             string dateOfBirth, int mobile, string imgUrl, string address);
        Task<int> GetPatientId();
    }
}
