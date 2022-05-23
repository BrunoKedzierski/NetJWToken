using Microsoft.EntityFrameworkCore;
using PharmacyWebAPI.Models;

namespace PharmacyWebAPI
{
    public class PharmacyDbContext : DbContext
    {
        public PharmacyDbContext(DbContextOptions options) : base(options)
        {
        }

        public PharmacyDbContext()
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
       public  DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SU5PG5A;Initial Catalog=Pharmacy;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(d =>
            {


                d.HasData(

                    new Doctor
                    {
                        IdDoctor = 1,
                        FirstName = "Karol",
                        LastName = "wojtyla",
                        EmailName = "kar@wp.pl"

                    }


                    );



            });



            modelBuilder.Entity<User>(d =>
            {


                d.HasData(

                    new User
                    {
                        IdUser = 1,
                        Login = "test",
                        Password = "testowy",
                        CreatedOn = DateTime.Now,
                        Role = "Admin"


                    }


                    );



            });





        }
    }
}
