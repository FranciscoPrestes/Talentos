using System.Collections.Generic;
using Talentos.Application.Interfaces;
using Talentos.Domain.Entities;
using Talentos.Domain.Interfaces.Services;

namespace Talentos.Application.Services
{
    public class CandidatoAppService : AppServiceBase<Candidato>, ICandidatoAppService
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatoAppService(ICandidatoService candidatoService): base(candidatoService)
        {
            _candidatoService = candidatoService;
        }

        public void AvaliarCandidato(Candidato candidato)
        {
            _candidatoService.AvaliarCandidato(candidato);
        }

        public IEnumerable<Candidato> GetByEmail(string candidatoEmail)
        {
           return _candidatoService.GetByEmail(candidatoEmail);
        }
    }
}
