namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificolaclaseCliente : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cliente", "CondicionTributaria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "CondicionTributaria", c => c.Int(nullable: false));
        }
    }
}
