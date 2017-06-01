using Talentos.Application.Interfaces;
using Talentos.Domain.Entities.ValueObjects;
using Talentos.Domain.Interfaces.Services;

namespace Talentos.Application.Services
{
    public class TecnologiaAppService : AppServiceBase<Tecnologia>, ITecnologiaAppService
    {
        private readonly ITecnologiaService _tecnologiaService;

        public TecnologiaAppService(ITecnologiaService tecnologiaService): base(tecnologiaService)
        {
            _tecnologiaService = tecnologiaService;
        }
    }
}
