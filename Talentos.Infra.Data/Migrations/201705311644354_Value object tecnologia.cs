namespace Talentos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Valueobjecttecnologia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Habilidade", "TecnologiaId", c => c.Int(nullable: false));
            AddColumn("dbo.Habilidade", "Tecnologia_TecnologiaId", c => c.Int(nullable: false));
            AddColumn("dbo.Habilidade", "Tecnologia_Nome", c => c.String(nullable: false, maxLength: 40, unicode: false));
            AddColumn("dbo.Habilidade", "Tecnologia_Nivel", c => c.Int(nullable: false));
            DropColumn("dbo.Habilidade", "Tecnologia");
            DropColumn("dbo.Habilidade", "Nivel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Habilidade", "Nivel", c => c.Int(nullable: false));
            AddColumn("dbo.Habilidade", "Tecnologia", c => c.String(nullable: false, maxLength: 40, unicode: false));
            DropColumn("dbo.Habilidade", "Tecnologia_Nivel");
            DropColumn("dbo.Habilidade", "Tecnologia_Nome");
            DropColumn("dbo.Habilidade", "Tecnologia_TecnologiaId");
            DropColumn("dbo.Habilidade", "TecnologiaId");
        }
    }
}
