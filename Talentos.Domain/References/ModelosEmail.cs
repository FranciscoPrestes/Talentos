using Talentos.Domain.Entities.ValueObjects;

namespace Talentos.Domain.References
{
    public class ModelosEmail
    {
       private Email _email;

        public ModelosEmail(string emailCandidato)
        {
            _email = new Email()
            {
                Rementente = "Meus Pedidos - Talentos",
                Assunto = "Obrigado por se candidatar",
                Endereco = emailCandidato
            };
        }

        public Email FrontEnd()
        {
            _email.Mensagem = "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador Front-End entraremos em contato.";

            return _email;

        }

        public Email BackEnd()
        {
            _email.Mensagem = "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador Back-End entraremos em contato.";

            return _email;
        }

        public Email Mobile()
        {
            _email.Mensagem = "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador Mobile entraremos em contato.";

            return _email;
        }

        public Email Generico()
        {
            _email.Mensagem = "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador entraremos em contato.";

            return _email;
        }
    }
}
