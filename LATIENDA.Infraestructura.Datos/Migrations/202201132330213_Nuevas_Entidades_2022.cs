namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nuevas_Entidades_2022 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumeroColor = c.Int(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descripcion = c.String(),
                        PorcentajeIva = c.Double(nullable: false),
                        Costo = c.Double(nullable: false),
                        MargendeGanancia = c.Double(nullable: false),
                        NetoGravado = c.Double(nullable: false),
                        CostoConIva = c.Double(nullable: false),
                        PreciodeVenta = c.Double(nullable: false),
                        Marca_ID = c.Int(),
                        Rubro_ID = c.Int(),
                        TipodeTalle_ID = c.Int(),
                        Venta_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Marcas", t => t.Marca_ID)
                .ForeignKey("dbo.Rubros", t => t.Rubro_ID)
                .ForeignKey("dbo.TipodeTalle", t => t.TipodeTalle_ID)
                .ForeignKey("dbo.Ventas", t => t.Venta_ID)
                .Index(t => t.Marca_ID)
                .Index(t => t.Rubro_ID)
                .Index(t => t.TipodeTalle_ID)
                .Index(t => t.Venta_ID);
            
            CreateTable(
                "dbo.Rubros",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TipodeTalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descriptiontipodetalle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Color_ID = c.Int(),
                        Talle_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Colores", t => t.Color_ID)
                .ForeignKey("dbo.Talles", t => t.Talle_ID)
                .Index(t => t.Color_ID)
                .Index(t => t.Talle_ID);
            
            CreateTable(
                "dbo.Talles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TipodeTalle_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TipodeTalle", t => t.TipodeTalle_ID)
                .Index(t => t.TipodeTalle_ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        NombredeUsuario = c.String(),
                        Clave = c.String(),
                        RolUsuario = c.Int(nullable: false),
                        Empleado_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleados", t => t.Empleado_ID)
                .Index(t => t.Empleado_ID);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TipodeSucursal = c.Int(nullable: false),
                        EmpleadoID = c.Int(nullable: false),
                        Legajo = c.Int(nullable: false),
                        Nombre = c.String(),
                        RolEmpleado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FechayHora = c.DateTime(nullable: false),
                        Numero = c.Int(nullable: false),
                        Cliente_ID = c.Int(),
                        LDV_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ID)
                .ForeignKey("dbo.LineadeVenta", t => t.LDV_ID)
                .ForeignKey("dbo.Usuarios", t => t.User_ID)
                .Index(t => t.Cliente_ID)
                .Index(t => t.LDV_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CondicionTributaria = c.Int(nullable: false),
                        Cuit = c.Long(nullable: false),
                        Nombre = c.String(),
                        Domicilio = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LineadeVenta",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Producto_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Productos", t => t.Producto_ID)
                .Index(t => t.Producto_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "User_ID", "dbo.Usuarios");
            DropForeignKey("dbo.Productos", "Venta_ID", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "LDV_ID", "dbo.LineadeVenta");
            DropForeignKey("dbo.LineadeVenta", "Producto_ID", "dbo.Productos");
            DropForeignKey("dbo.Ventas", "Cliente_ID", "dbo.Cliente");
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropForeignKey("dbo.Stocks", "Talle_ID", "dbo.Talles");
            DropForeignKey("dbo.Talles", "TipodeTalle_ID", "dbo.TipodeTalle");
            DropForeignKey("dbo.Stocks", "Color_ID", "dbo.Colores");
            DropForeignKey("dbo.Productos", "TipodeTalle_ID", "dbo.TipodeTalle");
            DropForeignKey("dbo.Productos", "Rubro_ID", "dbo.Rubros");
            DropForeignKey("dbo.Productos", "Marca_ID", "dbo.Marcas");
            DropIndex("dbo.LineadeVenta", new[] { "Producto_ID" });
            DropIndex("dbo.Ventas", new[] { "User_ID" });
            DropIndex("dbo.Ventas", new[] { "LDV_ID" });
            DropIndex("dbo.Ventas", new[] { "Cliente_ID" });
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            DropIndex("dbo.Talles", new[] { "TipodeTalle_ID" });
            DropIndex("dbo.Stocks", new[] { "Talle_ID" });
            DropIndex("dbo.Stocks", new[] { "Color_ID" });
            DropIndex("dbo.Productos", new[] { "Venta_ID" });
            DropIndex("dbo.Productos", new[] { "TipodeTalle_ID" });
            DropIndex("dbo.Productos", new[] { "Rubro_ID" });
            DropIndex("dbo.Productos", new[] { "Marca_ID" });
            DropTable("dbo.LineadeVenta");
            DropTable("dbo.Cliente");
            DropTable("dbo.Ventas");
            DropTable("dbo.Empleados");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Talles");
            DropTable("dbo.Stocks");
            DropTable("dbo.TipodeTalle");
            DropTable("dbo.Rubros");
            DropTable("dbo.Productos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Colores");
        }
    }
}
