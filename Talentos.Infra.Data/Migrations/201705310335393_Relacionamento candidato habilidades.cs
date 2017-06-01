namespace Talentos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relacionamentocandidatohabilidades : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Habilidade", "CandidatoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Habilidade", "CandidatoId");
            AddForeignKey("dbo.Habilidade", "CandidatoId", "dbo.Candidato", "CandidatoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Habilidade", "CandidatoId", "dbo.Candidato");
            DropIndex("dbo.Habilidade", new[] { "CandidatoId" });
            DropColumn("dbo.Habilidade", "CandidatoId");
        }
    }
}
