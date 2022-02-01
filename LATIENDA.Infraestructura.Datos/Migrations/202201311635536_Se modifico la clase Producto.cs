namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificolaclaseProducto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productos", "Venta_ID", "dbo.Ventas");
            DropIndex("dbo.Productos", new[] { "Venta_ID" });
            DropColumn("dbo.Productos", "Venta_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productos", "Venta_ID", c => c.Int());
            CreateIndex("dbo.Productos", "Venta_ID");
            AddForeignKey("dbo.Productos", "Venta_ID", "dbo.Ventas", "ID");
        }
    }
}
