namespace LATIENDA.Web.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modificacion21032022331PM : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            RenameColumn(table: "dbo.Usuarios", name: "Empleado_ID", newName: "EmpleadoID");
            AlterColumn("dbo.Usuarios", "EmpleadoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "EmpleadoID");
            AddForeignKey("dbo.Usuarios", "EmpleadoID", "dbo.Empleados", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "EmpleadoID", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "EmpleadoID" });
            AlterColumn("dbo.Usuarios", "EmpleadoID", c => c.Int());
            RenameColumn(table: "dbo.Usuarios", name: "EmpleadoID", newName: "Empleado_ID");
            CreateIndex("dbo.Usuarios", "Empleado_ID");
            AddForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados", "ID");
        }
    }
}
