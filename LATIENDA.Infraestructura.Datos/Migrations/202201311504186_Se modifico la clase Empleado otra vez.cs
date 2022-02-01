namespace LATIENDA.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemodificolaclaseEmpleadootravez : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Empleados", "EmpleadoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleados", "EmpleadoID", c => c.Int(nullable: false));
        }
    }
}
