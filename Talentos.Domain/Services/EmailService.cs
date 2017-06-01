using System;
using System.Net;
using System.Net.Mail;
using Talentos.Domain.Entities.ValueObjects;
using Talentos.Domain.Interfaces.Services;

namespace Talentos.Domain.Services
{
    public class EmailService : IEmailService
    {
        public Server Server { get; set; }
        public string Erro { get; set; }

        private Email _email;

        public bool SendEmailByGmail(Email email)
        {
            this.Server = Server.GetConfiguracaoServidorEmailGmail();
            this._email = email;

            //configurações do mailMessage
            MailMessage mailMessage = GetConfigMailMessage();

            //configuracao smtp
            SmtpClient client = GetConfigSmtpClient();


            try
            {
                client.Send(mailMessage);
                return true;
            }

            catch (Exception e)
            {
                Erro = e.Message;

                return false;
            }

        }

        

        private SmtpClient GetConfigSmtpClient()
        {
            return new SmtpClient
            {
                UseDefaultCredentials = Server.UsaDefaultCredentials,
                Credentials = new NetworkCredential(Server.Usuario, Server.Senha),
                Port = Server.Porta,
                Host = Server.SMTP,
                EnableSsl = Server.UsaSSL
            };
        }

        private MailMessage GetConfigMailMessage()
        {
            var mailMessage = new MailMessage()
            {
                From = new MailAddress(Server.Usuario, _email.Rementente, System.Text.Encoding.UTF8),
                Subject = _email.Assunto,
                SubjectEncoding = System.Text.Encoding.UTF8,
                Body = _email.Mensagem,
                BodyEncoding = System.Text.Encoding.UTF8,
                IsBodyHtml = true,
                Priority = MailPriority.High,
            };

            mailMessage.To.Add(_email.Endereco);

            return mailMessage;
        }
    }
}
    

