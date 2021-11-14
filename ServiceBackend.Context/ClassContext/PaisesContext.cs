using ServiceBackend.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ServiceBackend.Context    
{
    public partial class PaisesContext : DbContext
    {
        public PaisesContext()
            : base("name=PaisesConnection")
        {
        }

        public virtual DbSet<Localidade> Localidades { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Provincias)
                .WithRequired(e => e.Pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Localidades)
                .WithRequired(e => e.Provincia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Producto>()
                .Property(e => e.Marca)
                .IsFixedLength();

            modelBuilder.Entity<Producto>()
                .Property(e => e.Descripción)
                .IsFixedLength();
        }
    }
}
