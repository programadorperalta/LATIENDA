namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificaronlasclasesCOLORMARCARUBRO : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Colores", "NumeroColor");
            DropColumn("dbo.Marcas", "Numero");
            DropColumn("dbo.Rubros", "Numero");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rubros", "Numero", c => c.Int(nullable: false));
            AddColumn("dbo.Marcas", "Numero", c => c.Int(nullable: false));
            AddColumn("dbo.Colores", "NumeroColor", c => c.Int(nullable: false));
        }
    }
}
