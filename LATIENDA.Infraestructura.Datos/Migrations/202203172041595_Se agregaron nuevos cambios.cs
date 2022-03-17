namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seagregaronnuevoscambios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comprobante",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        TipodeComprobante = c.Int(nullable: false),
                        Fecha = c.String(),
                        PuntodeVenta_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PuntosdeVenta", t => t.PuntodeVenta_ID)
                .Index(t => t.PuntodeVenta_ID);
            
            AddColumn("dbo.Ventas", "Comprobante_ID", c => c.Int());
            CreateIndex("dbo.Ventas", "Comprobante_ID");
            AddForeignKey("dbo.Ventas", "Comprobante_ID", "dbo.Comprobante", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "Comprobante_ID", "dbo.Comprobante");
            DropForeignKey("dbo.Comprobante", "PuntodeVenta_ID", "dbo.PuntosdeVenta");
            DropIndex("dbo.Comprobante", new[] { "PuntodeVenta_ID" });
            DropIndex("dbo.Ventas", new[] { "Comprobante_ID" });
            DropColumn("dbo.Ventas", "Comprobante_ID");
            DropTable("dbo.Comprobante");
        }
    }
}
