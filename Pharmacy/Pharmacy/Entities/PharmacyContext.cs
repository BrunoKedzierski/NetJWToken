using Microsoft.EntityFrameworkCore;
using Pharmacy.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Pharmacy.Entities
{
    public class PharmacyContext : DbContext
    {
       public virtual DbSet<Medicament> Medicaments { get; set; }
       public virtual DbSet<Prescription> Prescriptions { get; set; }
       public virtual DbSet<PrescriptionMedicament> PrescriptionMedicaments{ get; set; }

       public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options) {}

        public PharmacyContext() { }


        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfigurationsFromAssembly(typeof(MedicamentEFConfig).GetTypeInfo().Assembly);
        }   
       

    }
}
