namespace Talentos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTecnologias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tecnologia",
                c => new
                    {
                        TecnologiaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.TecnologiaId);
            
            AddColumn("dbo.Habilidade", "Nivel", c => c.Int(nullable: false));
            CreateIndex("dbo.Habilidade", "TecnologiaId");
            AddForeignKey("dbo.Habilidade", "TecnologiaId", "dbo.Tecnologia", "TecnologiaId");
            DropColumn("dbo.Habilidade", "Tecnologia_TecnologiaId");
            DropColumn("dbo.Habilidade", "Tecnologia_Nome");
            DropColumn("dbo.Habilidade", "Tecnologia_Nivel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Habilidade", "Tecnologia_Nivel", c => c.Int(nullable: false));
            AddColumn("dbo.Habilidade", "Tecnologia_Nome", c => c.String(nullable: false, maxLength: 40, unicode: false));
            AddColumn("dbo.Habilidade", "Tecnologia_TecnologiaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Habilidade", "TecnologiaId", "dbo.Tecnologia");
            DropIndex("dbo.Habilidade", new[] { "TecnologiaId" });
            DropColumn("dbo.Habilidade", "Nivel");
            DropTable("dbo.Tecnologia");
        }
    }
}
