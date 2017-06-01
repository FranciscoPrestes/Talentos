namespace Talentos.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Ajustetabelacandidato : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Habilidade", "TecnologiaId", "dbo.Tecnologia");
            DropIndex("dbo.Habilidade", new[] { "TecnologiaId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Habilidade", "TecnologiaId");
            AddForeignKey("dbo.Habilidade", "TecnologiaId", "dbo.Tecnologia", "TecnologiaId");
        }
    }
}
