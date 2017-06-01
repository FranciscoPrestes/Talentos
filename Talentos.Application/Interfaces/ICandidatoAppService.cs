using System.Collections.Generic;
using Talentos.Domain.Entities;

namespace Talentos.Application.Interfaces
{
    public interface ICandidatoAppService : IAppServiceBase<Candidato>
    {
        void AvaliarCandidato(Candidato candidato);
        IEnumerable<Candidato> GetByEmail(string candidatoEmail);
    }
}
