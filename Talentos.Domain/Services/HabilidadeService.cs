using System.Collections.Generic;
using Talentos.Domain.Entities;
using Talentos.Domain.Interfaces.Repository;
using Talentos.Domain.Interfaces.Services;

namespace Talentos.Domain.Services
{
   public class HabilidadeService : ServiceBase<Habilidade>, IHabilidadeService
    {
        private readonly IHabilidadeRepository _habilidadeRepository;

        public HabilidadeService(IHabilidadeRepository habilidadeRepository): base(habilidadeRepository)
        {
            _habilidadeRepository = habilidadeRepository;
        }

       
    }
}
