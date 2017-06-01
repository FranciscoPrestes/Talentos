using System.Collections.Generic;
using Talentos.Domain.Entities;

namespace Talentos.Domain.Interfaces.Repository
{
    public interface ICandidatoRepository : IRepositoryBase<Candidato>
    {
        IEnumerable<Candidato> GetByEmail(string candidatoEmail);
    }
}
