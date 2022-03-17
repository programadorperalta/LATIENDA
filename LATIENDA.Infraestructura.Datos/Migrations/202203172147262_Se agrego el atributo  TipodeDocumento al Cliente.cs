namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeagregoelatributoTipodeDocumentoalCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "TipoDeDocumento", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "TipoDeDocumento");
        }
    }
}
