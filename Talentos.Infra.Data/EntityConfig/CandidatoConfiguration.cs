using System.Data.Entity.ModelConfiguration;
using Talentos.Domain.Entities;

namespace Talentos.Infra.Data.EntityConfig 
{
  public class CandidatoConfiguration : EntityTypeConfiguration<Candidato>
    {
        public CandidatoConfiguration()
        {
            HasKey(c => c.CandidatoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            
        }
    }
}
