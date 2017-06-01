using Talentos.Application.Interfaces;
using Talentos.Domain.Entities;
using Talentos.Domain.Interfaces.Services;

namespace Talentos.Application.Services
{
   public class HabilidadeAppService : AppServiceBase<Habilidade>, IHabilidadeAppService
    {
        private readonly IHabilidadeService _habilidadeService;

        public HabilidadeAppService(IHabilidadeService habilidadeService): base(habilidadeService)
        {
            _habilidadeService = habilidadeService;
        }


      
    }
}

    