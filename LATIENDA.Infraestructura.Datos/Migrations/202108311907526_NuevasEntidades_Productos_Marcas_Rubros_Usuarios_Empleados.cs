namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevasEntidades_Productos_Marcas_Rubros_Usuarios_Empleados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Numero = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Numero);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        MarcaID = c.Int(nullable: false),
                        RubroID = c.Int(nullable: false),
                        Descripcion = c.String(),
                        PorcentajeIva = c.Double(nullable: false),
                        Costo = c.Double(nullable: false),
                        MargendeGanancia = c.Double(nullable: false),
                        NetoGravado = c.Double(nullable: false),
                        CostoConIva = c.Double(nullable: false),
                        PreciodeVenta = c.Double(nullable: false),
                        Marca_Numero = c.Int(),
                        Rubro_Numero = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Marcas", t => t.Marca_Numero)
                .ForeignKey("dbo.Rubros", t => t.Rubro_Numero)
                .Index(t => t.Marca_Numero)
                .Index(t => t.Rubro_Numero);
            
            CreateTable(
                "dbo.Rubros",
                c => new
                    {
                        Numero = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Numero);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        NombredeUsuario = c.String(),
                        Clave = c.String(),
                        RolUsuario = c.Int(nullable: false),
                        Empleado_EmpleadoID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Empleados", t => t.Empleado_EmpleadoID)
                .Index(t => t.Empleado_EmpleadoID);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                        TipodeSucursal = c.Int(nullable: false),
                        Legajo = c.Int(nullable: false),
                        Nombre = c.String(),
                        RolEmpleado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Empleado_EmpleadoID", "dbo.Empleados");
            DropForeignKey("dbo.Productos", "Rubro_Numero", "dbo.Rubros");
            DropForeignKey("dbo.Productos", "Marca_Numero", "dbo.Marcas");
            DropIndex("dbo.Usuarios", new[] { "Empleado_EmpleadoID" });
            DropIndex("dbo.Productos", new[] { "Rubro_Numero" });
            DropIndex("dbo.Productos", new[] { "Marca_Numero" });
            DropTable("dbo.Empleados");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Rubros");
            DropTable("dbo.Productos");
            DropTable("dbo.Marcas");
        }
    }
}
