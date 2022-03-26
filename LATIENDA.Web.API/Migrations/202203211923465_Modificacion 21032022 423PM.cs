namespace LATIENDA.Web.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modificacion21032022423PM : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productos", "Marca_ID", "dbo.Marcas");
            DropForeignKey("dbo.Productos", "Rubro_ID", "dbo.Rubros");
            DropForeignKey("dbo.Productos", "TipodeTalle_ID", "dbo.TipodeTalle");
            DropIndex("dbo.Productos", new[] { "Marca_ID" });
            DropIndex("dbo.Productos", new[] { "Rubro_ID" });
            DropIndex("dbo.Productos", new[] { "TipodeTalle_ID" });
            RenameColumn(table: "dbo.Productos", name: "Marca_ID", newName: "MarcaID");
            RenameColumn(table: "dbo.Productos", name: "Rubro_ID", newName: "RubroID");
            RenameColumn(table: "dbo.Productos", name: "TipodeTalle_ID", newName: "TipodeTalleID");
            AlterColumn("dbo.Productos", "MarcaID", c => c.Int(nullable: false));
            AlterColumn("dbo.Productos", "RubroID", c => c.Int(nullable: false));
            AlterColumn("dbo.Productos", "TipodeTalleID", c => c.Int(nullable: false));
            CreateIndex("dbo.Productos", "MarcaID");
            CreateIndex("dbo.Productos", "RubroID");
            CreateIndex("dbo.Productos", "TipodeTalleID");
            AddForeignKey("dbo.Productos", "MarcaID", "dbo.Marcas", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Productos", "RubroID", "dbo.Rubros", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Productos", "TipodeTalleID", "dbo.TipodeTalle", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "TipodeTalleID", "dbo.TipodeTalle");
            DropForeignKey("dbo.Productos", "RubroID", "dbo.Rubros");
            DropForeignKey("dbo.Productos", "MarcaID", "dbo.Marcas");
            DropIndex("dbo.Productos", new[] { "TipodeTalleID" });
            DropIndex("dbo.Productos", new[] { "RubroID" });
            DropIndex("dbo.Productos", new[] { "MarcaID" });
            AlterColumn("dbo.Productos", "TipodeTalleID", c => c.Int());
            AlterColumn("dbo.Productos", "RubroID", c => c.Int());
            AlterColumn("dbo.Productos", "MarcaID", c => c.Int());
            RenameColumn(table: "dbo.Productos", name: "TipodeTalleID", newName: "TipodeTalle_ID");
            RenameColumn(table: "dbo.Productos", name: "RubroID", newName: "Rubro_ID");
            RenameColumn(table: "dbo.Productos", name: "MarcaID", newName: "Marca_ID");
            CreateIndex("dbo.Productos", "TipodeTalle_ID");
            CreateIndex("dbo.Productos", "Rubro_ID");
            CreateIndex("dbo.Productos", "Marca_ID");
            AddForeignKey("dbo.Productos", "TipodeTalle_ID", "dbo.TipodeTalle", "ID");
            AddForeignKey("dbo.Productos", "Rubro_ID", "dbo.Rubros", "ID");
            AddForeignKey("dbo.Productos", "Marca_ID", "dbo.Marcas", "ID");
        }
    }
}
