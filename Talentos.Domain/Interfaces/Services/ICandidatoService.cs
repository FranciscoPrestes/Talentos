using System.Collections.Generic;
using Talentos.Domain.Entities;

namespace Talentos.Domain.Interfaces.Services
{
    public interface ICandidatoService : IServiceBase<Candidato>
    {
        void AvaliarCandidato(Candidato candidato);
        IEnumerable<Candidato> GetByEmail(string candidatoEmail);
    }
}
