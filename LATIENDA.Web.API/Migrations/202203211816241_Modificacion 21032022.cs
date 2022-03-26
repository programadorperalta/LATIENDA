namespace LATIENDA.Web.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modificacion21032022 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Empleado_ID1", c => c.Int());
            CreateIndex("dbo.Usuarios", "Empleado_ID1");
            AddForeignKey("dbo.Usuarios", "Empleado_ID1", "dbo.Empleados", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Empleado_ID1", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID1" });
            DropColumn("dbo.Usuarios", "Empleado_ID1");
        }
    }
}
