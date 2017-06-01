namespace Talentos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mudancaemailparavalueobject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidato", "Email", c => c.String(nullable: false, maxLength: 150, unicode: false));
            DropColumn("dbo.Candidato", "Email_EnderecoEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidato", "Email_EnderecoEmail", c => c.String(nullable: false, maxLength: 150, unicode: false));
            DropColumn("dbo.Candidato", "Email");
        }
    }
}
