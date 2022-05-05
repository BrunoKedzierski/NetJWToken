using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Entities.Configurations
{
    public class MedicamentEFConfig : IEntityTypeConfiguration<Medicament>()
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.ToTable("Medicament");
            builder.HasKey(k => k.IdMedicament).HasName("PK_Medicament");
            builder.Property(p => p.IdMedicament).UseIdentityColumn();
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(100);
            builder.Property(p => p.Type).HasMaxLength(100);
        }
    }
}
