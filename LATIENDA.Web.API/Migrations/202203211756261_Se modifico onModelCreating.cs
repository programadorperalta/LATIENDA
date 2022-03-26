namespace LATIENDA.Web.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificoonModelCreating : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            AlterColumn("dbo.Usuarios", "Empleado_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "Empleado_ID");
            AddForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            AlterColumn("dbo.Usuarios", "Empleado_ID", c => c.Int());
            CreateIndex("dbo.Usuarios", "Empleado_ID");
            AddForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados", "ID");
        }
    }
}
