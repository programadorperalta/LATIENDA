namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SehizounasegundamodificacionalaclaseCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "CondicionTributaria", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "CondicionTributaria");
        }
    }
}
