﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiFinalFantaconeFederico.Data;

namespace WebApiFinalFantaconeFederico.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiFinalFantaconeFederico.Models.Doctor", b =>
                {
                    b.Property<int>("Doctor_No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Hospital_Cod")
                        .HasColumnType("int");

                    b.Property<int?>("Hospital_Cod1")
                        .HasColumnType("int");

                    b.HasKey("Doctor_No");

                    b.HasIndex("Hospital_Cod1");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("WebApiFinalFantaconeFederico.Models.Hospital", b =>
                {
                    b.Property<int>("Hospital_Cod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Num_Cama")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Hospital_Cod");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("WebApiFinalFantaconeFederico.Models.Doctor", b =>
                {
                    b.HasOne("WebApiFinalFantaconeFederico.Models.Hospital", "Hospital")
                        .WithMany("Doctores")
                        .HasForeignKey("Hospital_Cod1");
                });
#pragma warning restore 612, 618
        }
    }
}
