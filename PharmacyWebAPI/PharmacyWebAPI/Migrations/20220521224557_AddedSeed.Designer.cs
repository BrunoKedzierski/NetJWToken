﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyWebAPI;

#nullable disable

namespace PharmacyWebAPI.Migrations
{
    [DbContext(typeof(PharmacyDbContext))]
    [Migration("20220521224557_AddedSeed")]
    partial class AddedSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MedicamentPrescription", b =>
                {
                    b.Property<int>("MedicamentsIdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("PrescritpionsIdPrescription")
                        .HasColumnType("int");

                    b.HasKey("MedicamentsIdMedicament", "PrescritpionsIdPrescription");

                    b.HasIndex("PrescritpionsIdPrescription");

                    b.ToTable("MedicamentPrescription");
                });

            modelBuilder.Entity("PharmacyWebAPI.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"), 1L, 1);

                    b.Property<string>("EmailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            EmailName = "kar@wp.pl",
                            FirstName = "Karol",
                            LastName = "wojtyla"
                        });
                });

            modelBuilder.Entity("PharmacyWebAPI.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedicament"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("PharmacyWebAPI.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatient"), 1L, 1);

                    b.Property<DateTime>("BrithDate")
                        .HasColumnType("Date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PharmacyWebAPI.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrescription"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("Date");

                    b.Property<int>("doctorIdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("patientIdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("doctorIdDoctor");

                    b.HasIndex("patientIdPatient");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("MedicamentPrescription", b =>
                {
                    b.HasOne("PharmacyWebAPI.Models.Medicament", null)
                        .WithMany()
                        .HasForeignKey("MedicamentsIdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyWebAPI.Models.Prescription", null)
                        .WithMany()
                        .HasForeignKey("PrescritpionsIdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharmacyWebAPI.Models.Prescription", b =>
                {
                    b.HasOne("PharmacyWebAPI.Models.Doctor", "doctor")
                        .WithMany("prescriptions")
                        .HasForeignKey("doctorIdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyWebAPI.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patientIdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("PharmacyWebAPI.Models.Doctor", b =>
                {
                    b.Navigation("prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
