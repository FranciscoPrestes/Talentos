using Talentos.Domain.Entities.ValueObjects;
using Talentos.Domain.Interfaces.Repository;
using Talentos.Domain.Interfaces.Services;

namespace Talentos.Domain.Services
{
   public class TecnologiaService : ServiceBase<Tecnologia>, ITecnologiaService
    {
        private readonly ITecnologiaRepository _tecnologiaRepository;

        public TecnologiaService(ITecnologiaRepository tecnologiaRepository): base(tecnologiaRepository)
        {
            _tecnologiaRepository = tecnologiaRepository;
        }
    }
}
