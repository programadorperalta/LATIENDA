namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificolaclaseStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stocks", "Producto_ID", c => c.Int());
            CreateIndex("dbo.Stocks", "Producto_ID");
            AddForeignKey("dbo.Stocks", "Producto_ID", "dbo.Productos", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Producto_ID", "dbo.Productos");
            DropIndex("dbo.Stocks", new[] { "Producto_ID" });
            DropColumn("dbo.Stocks", "Producto_ID");
        }
    }
}
