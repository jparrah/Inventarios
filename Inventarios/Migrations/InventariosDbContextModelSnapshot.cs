﻿// <auto-generated />
using System;
using Inventarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventarios.Migrations
{
    [DbContext(typeof(InventariosDbContext))]
    partial class InventariosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EquiposDefectadosLabores", b =>
                {
                    b.Property<int>("EquiposDefectadosId")
                        .HasColumnType("int");

                    b.Property<int>("LaboresId")
                        .HasColumnType("int");

                    b.HasKey("EquiposDefectadosId", "LaboresId");

                    b.HasIndex("LaboresId");

                    b.ToTable("EquiposDefectadosLabores");
                });

            modelBuilder.Entity("Inventarios.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NombreArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Inventarios.Models.Componente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EquiposId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquiposId");

                    b.ToTable("Componentes");
                });

            modelBuilder.Entity("Inventarios.Models.Defectacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NombreDefectacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Defectaciones");
                });

            modelBuilder.Entity("Inventarios.Models.Equipos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<float>("Depreciacion")
                        .HasColumnType("real");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<long>("Inventario")
                        .HasColumnType("bigint");

                    b.Property<long>("Sello")
                        .HasColumnType("bigint");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<int>("TipoEquipoId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("SucursalId");

                    b.HasIndex("TipoEquipoId");

                    b.ToTable("Equipos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Equipos");
                });

            modelBuilder.Entity("Inventarios.Models.EquiposBaja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId")
                        .IsUnique();

                    b.ToTable("EquiposBajas");
                });

            modelBuilder.Entity("Inventarios.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Inventarios.Models.Labores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NombreLabor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Labores");
                });

            modelBuilder.Entity("Inventarios.Models.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("EquiposId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fundamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SucursalId")
                        .HasColumnType("int");

                    b.Property<int>("TecnicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquiposId")
                        .IsUnique()
                        .HasFilter("[EquiposId] IS NOT NULL");

                    b.HasIndex("SucursalId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("Inventarios.Models.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CodigoSucursal")
                        .HasColumnType("int");

                    b.Property<string>("NombreSucursal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("Inventarios.Models.Tecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("CI")
                        .HasColumnType("bigint");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("Inventarios.Models.TipoEquipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NombreTipoEquipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoEquipos");
                });

            modelBuilder.Entity("Inventarios.Models.EquiposDefectados", b =>
                {
                    b.HasBaseType("Inventarios.Models.Equipos");

                    b.Property<int>("DefectacionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaReparada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.HasIndex("DefectacionId");

                    b.HasDiscriminator().HasValue("EquiposDefectados");
                });

            modelBuilder.Entity("EquiposDefectadosLabores", b =>
                {
                    b.HasOne("Inventarios.Models.EquiposDefectados", null)
                        .WithMany()
                        .HasForeignKey("EquiposDefectadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventarios.Models.Labores", null)
                        .WithMany()
                        .HasForeignKey("LaboresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inventarios.Models.Componente", b =>
                {
                    b.HasOne("Inventarios.Models.Equipos", "Equipos")
                        .WithMany("Componentes")
                        .HasForeignKey("EquiposId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Inventarios.Models.Equipos", b =>
                {
                    b.HasOne("Inventarios.Models.Area", "Area")
                        .WithMany("Equipos")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventarios.Models.Estado", "Estado")
                        .WithMany("Equipos")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventarios.Models.Sucursal", "Sucursal")
                        .WithMany("Equipos")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventarios.Models.TipoEquipo", "Medios")
                        .WithMany("Equipos")
                        .HasForeignKey("TipoEquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Estado");

                    b.Navigation("Medios");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("Inventarios.Models.EquiposBaja", b =>
                {
                    b.HasOne("Inventarios.Models.Orden", "Orden")
                        .WithOne("EquiposBaja")
                        .HasForeignKey("Inventarios.Models.EquiposBaja", "OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("Inventarios.Models.Orden", b =>
                {
                    b.HasOne("Inventarios.Models.Equipos", "Equipos")
                        .WithOne("Orden")
                        .HasForeignKey("Inventarios.Models.Orden", "EquiposId");

                    b.HasOne("Inventarios.Models.Sucursal", "Sucursal")
                        .WithMany("Ordenes")
                        .HasForeignKey("SucursalId");

                    b.HasOne("Inventarios.Models.Tecnico", "Tecnico")
                        .WithMany("Ordenes")
                        .HasForeignKey("TecnicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipos");

                    b.Navigation("Sucursal");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("Inventarios.Models.EquiposDefectados", b =>
                {
                    b.HasOne("Inventarios.Models.Defectacion", "Defectacion")
                        .WithMany("EquiposDefectados")
                        .HasForeignKey("DefectacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Defectacion");
                });

            modelBuilder.Entity("Inventarios.Models.Area", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Inventarios.Models.Defectacion", b =>
                {
                    b.Navigation("EquiposDefectados");
                });

            modelBuilder.Entity("Inventarios.Models.Equipos", b =>
                {
                    b.Navigation("Componentes");

                    b.Navigation("Orden")
                        .IsRequired();
                });

            modelBuilder.Entity("Inventarios.Models.Estado", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Inventarios.Models.Orden", b =>
                {
                    b.Navigation("EquiposBaja")
                        .IsRequired();
                });

            modelBuilder.Entity("Inventarios.Models.Sucursal", b =>
                {
                    b.Navigation("Equipos");

                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("Inventarios.Models.Tecnico", b =>
                {
                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("Inventarios.Models.TipoEquipo", b =>
                {
                    b.Navigation("Equipos");
                });
#pragma warning restore 612, 618
        }
    }
}
