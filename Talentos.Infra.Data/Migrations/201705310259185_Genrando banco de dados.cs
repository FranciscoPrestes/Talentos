namespace Talentos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genrandobancodedados : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.HabilidadeId)
                .ForeignKey("dbo.Candidato", t => t.Candidato_CandidatoId)
                .Index(t => t.Candidato_CandidatoId);
            
            DropColumn("dbo.Candidato", "Habilidades_Html");
            DropColumn("dbo.Candidato", "Habilidades_Css");
            DropColumn("dbo.Candidato", "Habilidades_Javascript");
            DropColumn("dbo.Candidato", "Habilidades_Python");
            DropColumn("dbo.Candidato", "Habilidades_Django");
            DropColumn("dbo.Candidato", "Habilidades_iOS");
            DropColumn("dbo.Candidato", "Habilidades_Android");
           
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Administrador",
                c => new
                    {
                        AdministradorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email_EnderecoEmail = c.String(nullable: false, maxLength: 100, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AdministradorId);
            
            AddColumn("dbo.Candidato", "Habilidades_Android", c => c.Int(nullable: false));
            AddColumn("dbo.Candidato", "Habilidades_iOS", c => c.Int(nullable: false));
            AddColumn("dbo.Candidato", "Habilidades_Django", c => c.Int(nullable: false));
            AddColumn("dbo.Candidato", "Habilidades_Python", c => c.Int(nullable: false));
            AddColumn("dbo.Candidato", "Habilidades_Javascript", c => c.Int(nullable: false));
            AddColumn("dbo.Candidato", "Habilidades_Css", c => c.Int(nullable: false));
            AddColumn("dbo.Candidato", "Habilidades_Html", c => c.Int(nullable: false));
            DropForeignKey("dbo.Habilidade", "Candidato_CandidatoId", "dbo.Candidato");
            DropIndex("dbo.Habilidade", new[] { "Candidato_CandidatoId" });
            DropTable("dbo.Habilidade");
        }
    }
}
