using System.Data.Entity.ModelConfiguration;
using Talentos.Domain.Entities;

namespace Talentos.Infra.Data.EntityConfig
{
  public class HabilidadeConfiguration : EntityTypeConfiguration<Habilidade>
    {
        public HabilidadeConfiguration()
        {
            HasKey(c => c.HabilidadeId);

            Property(c => c.Nivel)
                .IsRequired();

        }
    }
}
