using Talentos.Domain.Entities.ValueObjects;

namespace Talentos.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Talentos.Infra.Data.Context.TalentoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Talentos.Infra.Data.Context.TalentoContext context)
        {
            //Prenche As tecnologias basicas no banco
            //context.Tecnologias.AddOrUpdate(
            //  p => p.Nome,
            //  new Tecnologia { Nome = "HTML" },
            //  new Tecnologia { Nome = "CSS" },
            //  new Tecnologia { Nome = "JavaScript" },
            //  new Tecnologia { Nome = "Python" },
            //  new Tecnologia { Nome = "Django" },
            //  new Tecnologia { Nome = "IOS" },
            //  new Tecnologia { Nome = "Android" }
            //);

        }
    }
}
