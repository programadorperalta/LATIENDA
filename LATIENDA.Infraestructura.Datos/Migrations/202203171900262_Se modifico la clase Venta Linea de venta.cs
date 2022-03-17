namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificolaclaseVentaLineadeventa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ventas", "LineadeVenta_ID", c => c.Int());
            CreateIndex("dbo.Ventas", "LineadeVenta_ID");
            AddForeignKey("dbo.Ventas", "LineadeVenta_ID", "dbo.LineadeVenta", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "LineadeVenta_ID", "dbo.LineadeVenta");
            DropIndex("dbo.Ventas", new[] { "LineadeVenta_ID" });
            DropColumn("dbo.Ventas", "LineadeVenta_ID");
        }
    }
}
