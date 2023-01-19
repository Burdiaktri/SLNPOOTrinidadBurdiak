namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avion",
                c => new
                    {
                        AvionId = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominacion = c.String(nullable: false, maxLength: 50, unicode: false),
                        LineaAerea_IdLineaAerea = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AvionId)
                .ForeignKey("dbo.LineaAerea", t => t.LineaAerea_IdLineaAerea)
                .Index(t => t.LineaAerea_IdLineaAerea);
            
            CreateTable(
                "dbo.LineaAerea",
                c => new
                    {
                        LineaAereaId = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LineaAereaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_IdLineaAerea", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "LineaAerea_IdLineaAerea" });
            DropTable("dbo.LineaAerea");
            DropTable("dbo.Avion");
        }
    }
}
