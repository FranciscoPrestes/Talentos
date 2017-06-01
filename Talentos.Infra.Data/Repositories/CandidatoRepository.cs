using System.Collections.Generic;
using System.Linq;
using Talentos.Domain.Entities;
using Talentos.Domain.Interfaces.Repository;

namespace Talentos.Infra.Data.Repositories
{
    public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
    {
        public IEnumerable<Candidato> GetByEmail(string candidatoEmail)
        {
            return Db.Candidatos.Where(c => c.Email == candidatoEmail);
        }
    }
}
