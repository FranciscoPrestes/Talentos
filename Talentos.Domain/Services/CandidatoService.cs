using System.Collections.Generic;
using Talentos.Domain.Entities;
using Talentos.Domain.Interfaces.Repository;
using Talentos.Domain.Interfaces.Services;
using Talentos.Domain.Interfaces.Services.Developer;
using Talentos.Domain.References;

namespace Talentos.Domain.Services
{
   public class CandidatoService : ServiceBase<Candidato>, ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository): base(candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public void AvaliarCandidato(Candidato candidato)
        {
           bool ehFrontEnd = new FrontEndDeveloper().Avalia(candidato.Habilidades);
           bool ehBackEnd = new BackEndDeveloper().Avalia(candidato.Habilidades);
           bool ehMobile = new MobileDeveloper().Avalia(candidato.Habilidades);

            var emailService = new EmailService();
            var modeloEmail = new ModelosEmail(candidato.Email);

            if (ehFrontEnd)
            {
                emailService.SendEmailByGmail(modeloEmail.FrontEnd());
            }

            if (ehBackEnd)
            {
                emailService.SendEmailByGmail(modeloEmail.BackEnd());
            }

            if (ehMobile)
            {
                emailService.SendEmailByGmail(modeloEmail.Mobile());
            }

            if (!ehFrontEnd && !ehBackEnd && !ehMobile)
            {
                emailService.SendEmailByGmail(modeloEmail.Generico());
            }
        }

        public IEnumerable<Candidato> GetByEmail(string candidatoEmail)
        {
           return _candidatoRepository.GetByEmail(candidatoEmail);
        }
    }
}
