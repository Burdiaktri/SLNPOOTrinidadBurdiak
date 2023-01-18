namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Avion", "LineaAerea_IdLineaAerea", c => c.String(maxLength: 128));
            CreateIndex("dbo.Avion", "LineaAerea_IdLineaAerea");
            AddForeignKey("dbo.Avion", "LineaAerea_IdLineaAerea", "dbo.LineaAerea", "LineaAereaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_IdLineaAerea", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "LineaAerea_IdLineaAerea" });
            DropColumn("dbo.Avion", "LineaAerea_IdLineaAerea");
        }
    }
}
