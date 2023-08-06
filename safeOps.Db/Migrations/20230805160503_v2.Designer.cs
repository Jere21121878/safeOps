﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using safeOps.Db.Data;

#nullable disable

namespace safeOps.Db.Migrations
{
    [DbContext(typeof(DaBaContext))]
    [Migration("20230805160503_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("safeOps.Db.Data.Entities.A_T_S", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Herramientas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTecnico")
                        .HasColumnType("int");

                    b.Property<string>("Peligros")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proteccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarea")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTecnico");

                    b.ToTable("A_T_S");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Calendario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Fecha")
                        .HasColumnType("int");

                    b.Property<int>("LicenciadoId")
                        .HasColumnType("int");

                    b.Property<string>("Tarea")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LicenciadoId")
                        .IsUnique();

                    b.ToTable("Calendario");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Emergencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Instrucciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumEmergencia")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa")
                        .IsUnique();

                    b.ToTable("Emergencia");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Empleador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empleador");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpleador")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleador");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccidentesGeneral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccidentesMaquinaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccidentesPropios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccidentesQuimicos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa")
                        .IsUnique();

                    b.ToTable("Historial");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Legal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa")
                        .IsUnique();

                    b.ToTable("Legal");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Licenciado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpleador")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TCalzado")
                        .HasColumnType("int");

                    b.Property<int>("TInferior")
                        .HasColumnType("int");

                    b.Property<int>("TSuperior")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleador");

                    b.ToTable("Licenciado");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Maquinaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aplicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Mantenimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa")
                        .IsUnique();

                    b.ToTable("Maquinaria");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Multimedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdTecnico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTecnico");

                    b.ToTable("Multimedia");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Planos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa")
                        .IsUnique();

                    b.ToTable("Planos");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Quimicos", b =>
                {
                    b.Property<int>("NumeroOnu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumeroOnu"), 1L, 1);

                    b.Property<string>("Aplicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CAS")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Mantenimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumeroOnu");

                    b.HasIndex("IdEmpresa")
                        .IsUnique();

                    b.ToTable("Quimicos");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Tecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpleador")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<int>("IdLicenciado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TCalzado")
                        .HasColumnType("int");

                    b.Property<int>("TInferior")
                        .HasColumnType("int");

                    b.Property<int>("TSuperior")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleador");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdLicenciado");

                    b.ToTable("Tecnico");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.A_T_S", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Tecnico", "Tecnico")
                        .WithMany("A_T_S")
                        .HasForeignKey("IdTecnico")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Calendario", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Licenciado", "Licenciados")
                        .WithOne("Calendarios")
                        .HasForeignKey("safeOps.Db.Data.Entities.Calendario", "LicenciadoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Licenciados");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Emergencia", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empresa", "Empresa")
                        .WithOne("Emergencias")
                        .HasForeignKey("safeOps.Db.Data.Entities.Emergencia", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Empresa", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empleador", "Empleadors")
                        .WithMany("Empresas")
                        .HasForeignKey("IdEmpleador")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleadors");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Historial", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empresa", "Empresa")
                        .WithOne("Historials")
                        .HasForeignKey("safeOps.Db.Data.Entities.Historial", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Legal", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empresa", "Empresa")
                        .WithOne("Legals")
                        .HasForeignKey("safeOps.Db.Data.Entities.Legal", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Licenciado", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empleador", "Empleadors")
                        .WithMany("Licenciados")
                        .HasForeignKey("IdEmpleador")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleadors");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Maquinaria", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empresa", "Empresa")
                        .WithOne("Maquinarias")
                        .HasForeignKey("safeOps.Db.Data.Entities.Maquinaria", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Multimedia", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Tecnico", "Tecnico")
                        .WithMany("Multimedia")
                        .HasForeignKey("IdTecnico")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Planos", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empresa", "Empresa")
                        .WithOne("Planos")
                        .HasForeignKey("safeOps.Db.Data.Entities.Planos", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Quimicos", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empresa", "Empresa")
                        .WithOne("Quimicoss")
                        .HasForeignKey("safeOps.Db.Data.Entities.Quimicos", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Tecnico", b =>
                {
                    b.HasOne("safeOps.Db.Data.Entities.Empleador", "Empleador")
                        .WithMany("Tecnicos")
                        .HasForeignKey("IdEmpleador")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("safeOps.Db.Data.Entities.Empresa", "Empresa")
                        .WithMany("Tecnicos")
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("safeOps.Db.Data.Entities.Licenciado", "Licenciado")
                        .WithMany("Tecnicos")
                        .HasForeignKey("IdLicenciado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleador");

                    b.Navigation("Empresa");

                    b.Navigation("Licenciado");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Empleador", b =>
                {
                    b.Navigation("Empresas");

                    b.Navigation("Licenciados");

                    b.Navigation("Tecnicos");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Empresa", b =>
                {
                    b.Navigation("Emergencias");

                    b.Navigation("Historials");

                    b.Navigation("Legals");

                    b.Navigation("Maquinarias");

                    b.Navigation("Planos");

                    b.Navigation("Quimicoss");

                    b.Navigation("Tecnicos");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Licenciado", b =>
                {
                    b.Navigation("Calendarios");

                    b.Navigation("Tecnicos");
                });

            modelBuilder.Entity("safeOps.Db.Data.Entities.Tecnico", b =>
                {
                    b.Navigation("A_T_S");

                    b.Navigation("Multimedia");
                });
#pragma warning restore 612, 618
        }
    }
}
