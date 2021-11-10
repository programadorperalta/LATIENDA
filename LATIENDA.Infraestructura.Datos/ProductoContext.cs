using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.SqlServer;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;

namespace LATIENDA.Infraestructura.Datos
{
    public class ProductoContext : DbContext
    {

        public ProductoContext() : base("name=ProductoEntities")
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
                .HasKey(p => p.Codigo);

            modelBuilder
                .Entity<Marca>()
                .ToTable("Marcas")
                .HasKey(m => m.Numero);

            modelBuilder
                .Entity<Rubro>()
                .ToTable("Rubros")
                .HasKey(r => r.Numero);

            modelBuilder
                .Entity<Empleado>()
                .ToTable("Empleados")
                .HasKey(e => e.EmpleadoID);

            modelBuilder
                .Entity<Usuario>()
                .ToTable("Usuarios").HasKey(u => u.UserID);

            modelBuilder
                .Entity<Stock>()
                .ToTable("Stocks");

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Rubro> Rubros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Color> Colores { get; set; }
        public DbSet<Talle> Talles { get; set; }

    }
}
