namespace Talentos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaHabilidademapeadaecorrigidonomedetabelasparaplural : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habilidade",
                c => new
                    {
                        HabilidadeId = c.Int(nullable: false, identity: true),
                        Tecnologia = c.String(nullable: false, maxLength: 40, unicode: false),
                        Nivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HabilidadeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Habilidade");
        }
    }
}
