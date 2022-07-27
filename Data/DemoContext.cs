using System;
using System.Collections.Generic;
using Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo.Data
{
    public partial class DemoContext : DbContext
    {
        public DemoContext()
        {
        }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Configuracion> Configuracions { get; set; } = null!;
        public virtual DbSet<Solicitude> Solicitudes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.ToTable("Configuracion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSolicitud).HasColumnName("idSolicitud");

                entity.Property(e => e.Vencimiento).HasColumnName("vencimiento");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.Configuracions)
                    .HasForeignKey(d => d.IdSolicitud)
                    .HasConstraintName("FK_Configuracion_Solicitudes");
            });

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaCancelacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaCancelacion");

                entity.Property(e => e.FechaCreacion).HasColumnName("fechaCreacion");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
