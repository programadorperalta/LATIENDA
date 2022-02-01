namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificolaclaseUsuario : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "UserID", c => c.Int(nullable: false));
        }
    }
}
