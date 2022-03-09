namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nuevoscambios : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Colores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
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
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Marcas", t => t.Marca_ID)
                .ForeignKey("dbo.Rubros", t => t.Rubro_ID)
                .ForeignKey("dbo.TipodeTalle", t => t.TipodeTalle_ID)
                .Index(t => t.Marca_ID)
                .Index(t => t.Rubro_ID)
                .Index(t => t.TipodeTalle_ID);
            
            CreateTable(
                "dbo.Rubros",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
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
                        Producto_ID = c.Int(),
                        Talle_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Colores", t => t.Color_ID)
                .ForeignKey("dbo.Productos", t => t.Producto_ID)
                .ForeignKey("dbo.Talles", t => t.Talle_ID)
                .Index(t => t.Color_ID)
                .Index(t => t.Producto_ID)
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
                "dbo.TipodePago",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NombredeUsuario = c.String(),
                        Clave = c.String(),
                        Rolusuario = c.Int(nullable: false),
                        Imagen = c.Binary(nullable: true),
                        Empleado_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleados", t => t.Empleado_ID, cascadeDelete: true)
                .Index(t => t.Empleado_ID);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Legajo = c.Int(nullable: false),
                        Nombre = c.String(),
                        RolEmpleado = c.Int(nullable: false),
                        Sucursal_ID = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sucursales", t => t.Sucursal_ID)
                .Index(t => t.Sucursal_ID);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        FechayHora = c.DateTime(nullable: false),
                        Cliente_ID = c.Int(),
                        Pago_ID = c.Int(),
                        Usuario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ID)
                .ForeignKey("dbo.Pago", t => t.Pago_ID)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_ID)
                .Index(t => t.Cliente_ID)
                .Index(t => t.Pago_ID)
                .Index(t => t.Usuario_ID);
            
            CreateTable(
                "dbo.LineadeVenta",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Subtotal = c.Double(nullable: false),
                        Stock_ID = c.Int(),
                        Venta_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID)
                .ForeignKey("dbo.Ventas", t => t.Venta_ID)
                .Index(t => t.Stock_ID)
                .Index(t => t.Venta_ID);
            
            CreateTable(
                "dbo.Pago",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MontoAPagar = c.Double(nullable: false),
                        MontoRecibido = c.Double(nullable: false),
                        Vuelto = c.Double(nullable: false),
                        TipodePago_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TipodePago", t => t.TipodePago_ID)
                .Index(t => t.TipodePago_ID);
            
            CreateTable(
                "dbo.Sucursales",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        TipodeSucursal = c.Int(nullable: false),
                        Empleado_ID = c.Int(),
                        PuntodeVenta_ID = c.Int(),
                        Stock_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleados", t => t.Empleado_ID)
                .ForeignKey("dbo.PuntosdeVenta", t => t.PuntodeVenta_ID)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID)
                .Index(t => t.Empleado_ID)
                .Index(t => t.PuntodeVenta_ID)
                .Index(t => t.Stock_ID);
            
            CreateTable(
                "dbo.PuntosdeVenta",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Venta_ID = c.Int(),
                        Sucursal_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ventas", t => t.Venta_ID)
                .ForeignKey("dbo.Sucursales", t => t.Sucursal_ID)
                .Index(t => t.Venta_ID)
                .Index(t => t.Sucursal_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sucursales", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.PuntosdeVenta", "Sucursal_ID", "dbo.Sucursales");
            DropForeignKey("dbo.Sucursales", "PuntodeVenta_ID", "dbo.PuntosdeVenta");
            DropForeignKey("dbo.PuntosdeVenta", "Venta_ID", "dbo.Ventas");
            DropForeignKey("dbo.Empleados", "Sucursal_ID", "dbo.Sucursales");
            DropForeignKey("dbo.Sucursales", "Empleado_ID", "dbo.Empleados");
            DropForeignKey("dbo.Ventas", "Usuario_ID", "dbo.Usuarios");
            DropForeignKey("dbo.Ventas", "Pago_ID", "dbo.Pago");
            DropForeignKey("dbo.Pago", "TipodePago_ID", "dbo.TipodePago");
            DropForeignKey("dbo.LineadeVenta", "Venta_ID", "dbo.Ventas");
            DropForeignKey("dbo.LineadeVenta", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.Ventas", "Cliente_ID", "dbo.Cliente");
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropForeignKey("dbo.Stocks", "Talle_ID", "dbo.Talles");
            DropForeignKey("dbo.Talles", "TipodeTalle_ID", "dbo.TipodeTalle");
            DropForeignKey("dbo.Stocks", "Producto_ID", "dbo.Productos");
            DropForeignKey("dbo.Stocks", "Color_ID", "dbo.Colores");
            DropForeignKey("dbo.Productos", "TipodeTalle_ID", "dbo.TipodeTalle");
            DropForeignKey("dbo.Productos", "Rubro_ID", "dbo.Rubros");
            DropForeignKey("dbo.Productos", "Marca_ID", "dbo.Marcas");
            DropIndex("dbo.PuntosdeVenta", new[] { "Sucursal_ID" });
            DropIndex("dbo.PuntosdeVenta", new[] { "Venta_ID" });
            DropIndex("dbo.Sucursales", new[] { "Stock_ID" });
            DropIndex("dbo.Sucursales", new[] { "PuntodeVenta_ID" });
            DropIndex("dbo.Sucursales", new[] { "Empleado_ID" });
            DropIndex("dbo.Pago", new[] { "TipodePago_ID" });
            DropIndex("dbo.LineadeVenta", new[] { "Venta_ID" });
            DropIndex("dbo.LineadeVenta", new[] { "Stock_ID" });
            DropIndex("dbo.Ventas", new[] { "Usuario_ID" });
            DropIndex("dbo.Ventas", new[] { "Pago_ID" });
            DropIndex("dbo.Ventas", new[] { "Cliente_ID" });
            DropIndex("dbo.Empleados", new[] { "Sucursal_ID" });
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            DropIndex("dbo.Talles", new[] { "TipodeTalle_ID" });
            DropIndex("dbo.Stocks", new[] { "Talle_ID" });
            DropIndex("dbo.Stocks", new[] { "Producto_ID" });
            DropIndex("dbo.Stocks", new[] { "Color_ID" });
            DropIndex("dbo.Productos", new[] { "TipodeTalle_ID" });
            DropIndex("dbo.Productos", new[] { "Rubro_ID" });
            DropIndex("dbo.Productos", new[] { "Marca_ID" });
            DropTable("dbo.PuntosdeVenta");
            DropTable("dbo.Sucursales");
            DropTable("dbo.Pago");
            DropTable("dbo.LineadeVenta");
            DropTable("dbo.Ventas");
            DropTable("dbo.Empleados");
            DropTable("dbo.Usuarios");
            DropTable("dbo.TipodePago");
            DropTable("dbo.Talles");
            DropTable("dbo.Stocks");
            DropTable("dbo.TipodeTalle");
            DropTable("dbo.Rubros");
            DropTable("dbo.Productos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Colores");
            DropTable("dbo.Cliente");
        }
    }
}
