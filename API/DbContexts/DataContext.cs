using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DbContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        public DbSet<Doctor> Doctors{ get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<UserCredentials> UserCredentials { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}
