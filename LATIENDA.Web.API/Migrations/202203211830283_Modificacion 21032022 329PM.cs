namespace LATIENDA.Web.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modificacion21032022329PM : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "Empleado_ID1", "dbo.Empleados");
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID1" });
            AlterColumn("dbo.Usuarios", "Empleado_ID", c => c.Int());
            CreateIndex("dbo.Usuarios", "Empleado_ID");
            AddForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados", "ID");
            DropColumn("dbo.Usuarios", "Empleado_ID1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Empleado_ID1", c => c.Int());
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            AlterColumn("dbo.Usuarios", "Empleado_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "Empleado_ID1");
            CreateIndex("dbo.Usuarios", "Empleado_ID");
            AddForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Usuarios", "Empleado_ID1", "dbo.Empleados", "ID");
        }
    }
}
