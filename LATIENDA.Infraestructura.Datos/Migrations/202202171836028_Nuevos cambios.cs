namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nuevoscambios : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados");
            DropForeignKey("dbo.Sucursales", "Empleado_ID", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Empleado_ID" });
            DropColumn("dbo.Empleados", "ID");
            RenameColumn(table: "dbo.Empleados", name: "Empleado_ID", newName: "ID");
            DropPrimaryKey("dbo.Empleados");
            AlterColumn("dbo.Empleados", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Empleados", "ID");
            CreateIndex("dbo.Empleados", "ID");
            AddForeignKey("dbo.Sucursales", "Empleado_ID", "dbo.Empleados", "ID");
            DropColumn("dbo.Usuarios", "Empleado_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Empleado_ID", c => c.Int());
            DropForeignKey("dbo.Sucursales", "Empleado_ID", "dbo.Empleados");
            DropIndex("dbo.Empleados", new[] { "ID" });
            DropPrimaryKey("dbo.Empleados");
            AlterColumn("dbo.Empleados", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Empleados", "ID");
            RenameColumn(table: "dbo.Empleados", name: "ID", newName: "Empleado_ID");
            AddColumn("dbo.Empleados", "ID", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Usuarios", "Empleado_ID");
            AddForeignKey("dbo.Sucursales", "Empleado_ID", "dbo.Empleados", "ID");
            AddForeignKey("dbo.Usuarios", "Empleado_ID", "dbo.Empleados", "ID");
        }
    }
}
