using System.Data.Entity.ModelConfiguration;
using Talentos.Domain.Entities.ValueObjects;

namespace Talentos.Infra.Data.EntityConfig
{
    class TecnologiaConfiguration : EntityTypeConfiguration<Tecnologia>
    {
        public TecnologiaConfiguration()
        {
            HasKey(c => c.TecnologiaId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);
        }

    }
}
