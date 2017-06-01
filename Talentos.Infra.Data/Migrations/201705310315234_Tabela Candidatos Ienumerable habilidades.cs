namespace Talentos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaCandidatosIenumerablehabilidades : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Habilidade", "Candidato_CandidatoId", "dbo.Candidato");
            DropIndex("dbo.Habilidade", new[] { "Candidato_CandidatoId" });
            DropTable("dbo.Habilidade");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Habilidade",
                c => new
                    {
                        HabilidadeId = c.Int(nullable: false, identity: true),
                        Tecnologia = c.String(maxLength: 100, unicode: false),
                        Nivel = c.Int(nullable: false),
                        Candidato_CandidatoId = c.Int(),
                    })
                .PrimaryKey(t => t.HabilidadeId);
            
            CreateIndex("dbo.Habilidade", "Candidato_CandidatoId");
            AddForeignKey("dbo.Habilidade", "Candidato_CandidatoId", "dbo.Candidato", "CandidatoId");
        }
    }
}
