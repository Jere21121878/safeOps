using Microsoft.EntityFrameworkCore;
using safeOps.Db.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data
{
    public class DaBaContext : DbContext
    {
        public DbSet<Tecnico> Tecnicos { get; set; }


        public DbSet<Empleador> Empleadors { get; set; }
        public DbSet<A_T_S> A_T_Ss { get; set; }

        public DbSet<Calendario> Calendarios { get; set; }

        public DbSet<Emergencia> Emergencias { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Historial> Historials { get; set; }

        public DbSet<Legal> Legals { get; set; }

        public DbSet<Licenciado> Licenciados { get; set; }

        public DbSet<Maquinaria> Maquinarias { get; set; }

        public DbSet<Multimedia> Multimedias { get; set; }
        

        public DbSet<Planos> Planoss { get; set; }

        public DbSet<Quimicos> Quimicoss { get; set; }

        public DaBaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             modelBuilder.Entity<Tecnico>()
               .HasOne(t => t.Licenciado)
               .WithMany(l => l.Tecnicos)
               .HasForeignKey(t => t.IdLicenciado);

            modelBuilder.Entity<Tecnico>()
                .HasOne(t => t.Empleador)
                .WithMany(e => e.Tecnicos)
                .HasForeignKey(t => t.IdEmpleador);

            modelBuilder.Entity<Tecnico>()
                .HasOne(t => t.Empresa)
                .WithMany(e => e.Tecnicos)
                .HasForeignKey(t => t.IdEmpresa);


            modelBuilder.Entity<Licenciado>()
              .HasOne(l => l.Empleadors)
              .WithMany(e => e.Licenciados)
               .HasForeignKey(l => l.IdEmpleador);

            modelBuilder.Entity<Calendario>()
             .HasOne(e => e.Licenciados)
             .WithOne(l => l.Calendarios)
              .HasForeignKey<Calendario>(l => l.LicenciadoId);

            modelBuilder.Entity<Empresa>()
             .HasOne(l => l.Empleadors)
             .WithMany(e => e.Empresas)
              .HasForeignKey(l => l.IdEmpleador);

            modelBuilder.Entity<A_T_S>()
               .HasOne(t => t.Tecnico)
               .WithMany(l => l.A_T_S)
                .HasForeignKey(t => t.IdTecnico);

            modelBuilder.Entity<Multimedia>()
               .HasOne(t => t.Tecnico)
               .WithMany(l => l.Multimedia)
                .HasForeignKey(t => t.IdTecnico);

            modelBuilder.Entity<Empresa>()
              .HasOne(e => e.Emergencias)
              .WithOne(em => em.Empresa)
              .HasForeignKey<Emergencia>(em => em.IdEmpresa);

            modelBuilder.Entity<Empresa>()
              .HasOne(e => e.Historials)
              .WithOne(h => h.Empresa)
              .HasForeignKey<Historial>(h => h.IdEmpresa);

            modelBuilder.Entity<Empresa>()
              .HasOne(e => e.Legals)
              .WithOne(l => l.Empresa)
              .HasForeignKey<Legal>(l => l.IdEmpresa);

            modelBuilder.Entity<Empresa>()
              .HasOne(e => e.Planos)
              .WithOne(p => p.Empresa)
              .HasForeignKey<Planos>(p => p.IdEmpresa);

            //modelBuilder.Entity<Empresa>()
            //     .HasMany(e => Quimicoss)
            //     .WithMany(q => q.Empresas)
            //     .HasForeignKey(e => e.idEmpresa)
            //     .IsRequired()
            //     .OnDelete(DeleteBehavior.Cascade);

            if (modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");

            // for the other conventions, we do a metadata model loop
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                entityType.SetTableName(entityType.DisplayName());

                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            base.OnModelCreating(modelBuilder);
        }
        

    }
}
