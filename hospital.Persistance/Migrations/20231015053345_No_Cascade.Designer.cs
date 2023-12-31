﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hospital.Persistance.Context;

#nullable disable

namespace hospital.Persistance.Migrations
{
    [DbContext(typeof(hospitalContext))]
    [Migration("20231015053345_No_Cascade")]
    partial class No_Cascade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hospital.Domain.Entities.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Causa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Hora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Id_Medico")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Paciente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Medico");

                    b.HasIndex("Id_Paciente");

                    b.ToTable("Cita", (string)null);
                });

            modelBuilder.Entity("hospital.Domain.Entities.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("hospital.Domain.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsAlegico")
                        .HasColumnType("bit");

                    b.Property<bool>("EsFumador")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paciente", (string)null);
                });

            modelBuilder.Entity("hospital.Domain.Entities.Prueba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prueba", (string)null);
                });

            modelBuilder.Entity("hospital.Domain.Entities.Resultado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Completado")
                        .HasColumnType("bit");

                    b.Property<int?>("Id_Cita")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Paciente")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Prueba")
                        .HasColumnType("int");

                    b.Property<string>("Resultado_Final")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Cita");

                    b.HasIndex("Id_Paciente");

                    b.HasIndex("Id_Prueba");

                    b.ToTable("Resultado", (string)null);
                });

            modelBuilder.Entity("hospital.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tipo_Usuario")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("hospital.Domain.Entities.Cita", b =>
                {
                    b.HasOne("hospital.Domain.Entities.Medico", "Medico")
                        .WithMany("Citas")
                        .HasForeignKey("Id_Medico")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("hospital.Domain.Entities.Paciente", "Paciente")
                        .WithMany("Citas")
                        .HasForeignKey("Id_Paciente")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("hospital.Domain.Entities.Resultado", b =>
                {
                    b.HasOne("hospital.Domain.Entities.Cita", "Cita")
                        .WithMany("Resultados")
                        .HasForeignKey("Id_Cita")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("hospital.Domain.Entities.Paciente", "Paciente")
                        .WithMany("Resultados")
                        .HasForeignKey("Id_Paciente")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("hospital.Domain.Entities.Prueba", "Prueba")
                        .WithMany("Resultados")
                        .HasForeignKey("Id_Prueba")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Cita");

                    b.Navigation("Paciente");

                    b.Navigation("Prueba");
                });

            modelBuilder.Entity("hospital.Domain.Entities.Cita", b =>
                {
                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("hospital.Domain.Entities.Medico", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("hospital.Domain.Entities.Paciente", b =>
                {
                    b.Navigation("Citas");

                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("hospital.Domain.Entities.Prueba", b =>
                {
                    b.Navigation("Resultados");
                });
#pragma warning restore 612, 618
        }
    }
}
