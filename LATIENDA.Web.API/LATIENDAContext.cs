using LATIENDA.Web.API.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace LATIENDA.Web.API
{
    public class LATIENDAContext : DbContext
    {
        public LATIENDAContext() : base("name=ProductoEntities")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

            modelBuilder
                .Entity<Producto>()
                .ToTable("Productos")
                .HasKey(p => p.ID);

            modelBuilder
                .Entity<Venta>()
                .ToTable("Ventas")
                .HasKey(v => v.ID);


            modelBuilder
                .Entity<Talle>()
                .ToTable("Talles")
                .HasKey(p => p.ID);

            modelBuilder
                .Entity<Color>()
                .ToTable("Colores")
                .HasKey(p => p.ID);

            modelBuilder
                .Entity<Marca>()
                .ToTable("Marcas")
                .HasKey(m => m.ID);

            modelBuilder
                .Entity<Rubro>()
                .ToTable("Rubros")
                .HasKey(r => r.ID);

            modelBuilder
                .Entity<Empleado>()
                .ToTable("Empleados")
                .HasKey(e => e.ID);

            modelBuilder
                .Entity<Usuario>()
                .ToTable("Usuarios").HasKey(u => u.ID);

            modelBuilder
                .Entity<Stock>()
                .ToTable("Stocks").HasKey(s => s.ID);

            modelBuilder
                .Entity<Sucursal>().ToTable("Sucursales").HasKey(s => s.ID);

            modelBuilder.Entity<PuntodeVenta>().ToTable("PuntosdeVenta").HasKey(p => p.ID);

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Rubro> Rubros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Color> Colores { get; set; }
        public DbSet<Talle> Talles { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<TipodeTalle> TipodeTalles { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipodePago> TipodePagos { get; set; }

    }
}