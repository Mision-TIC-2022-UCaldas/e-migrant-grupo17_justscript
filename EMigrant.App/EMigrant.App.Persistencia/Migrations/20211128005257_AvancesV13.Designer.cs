﻿// <auto-generated />
using System;
using EMigrant.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMigrant.App.Persistencia.Migrations
{
    [DbContext(typeof(Conexion))]
    [Migration("20211128005257_AvancesV13")]
    partial class AvancesV13
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EMigrant.App.Dominio.Institucion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PagWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoServicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instituciones");
                });

            modelBuilder.Entity("EMigrant.App.Dominio.migrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisOrigen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SituacionLaboral")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("necesidadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("migrantes");
                });

            modelBuilder.Entity("EMigrant.App.Dominio.necesidades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescripcionAlimentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionAlojaPermanente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionAlojaTemporal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionAyudaLegal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionEducacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionEmpleo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionSalud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrioridadAlimentacion")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadAlojaPermanente")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadAyudaLegal")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadEducacion")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadEmpleo")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadSalud")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadTemporal")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Necesidad");
                });
#pragma warning restore 612, 618
        }
    }
}
