namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadSucursalModificada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stocks", "Sucursal_ID", c => c.Int());
            CreateIndex("dbo.Stocks", "Sucursal_ID");
            AddForeignKey("dbo.Stocks", "Sucursal_ID", "dbo.Sucursales", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Sucursal_ID", "dbo.Sucursales");
            DropIndex("dbo.Stocks", new[] { "Sucursal_ID" });
            DropColumn("dbo.Stocks", "Sucursal_ID");
        }
    }
}
