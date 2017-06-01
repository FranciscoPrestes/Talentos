using System;
using System.Runtime.CompilerServices;

namespace Talentos.Domain.Entities.ValueObjects
{
    public class Server
    {
        public string SMTP { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Porta { get; set; }
        public bool UsaSSL { get; set; }
        public bool FazAutenticacao { get; set; }
        public bool UsaDefaultCredentials { get; set; }

        internal static Server GetConfiguracaoServidorEmailGmail()
        {
            return new Server()
                {
                    Usuario = "saeguardian@gmail.com",
                    Senha = "paraDeDarProblema12",
                    SMTP = "smtp.gmail.com",
                    Porta = 587,
                    UsaSSL = true,
                    FazAutenticacao = true,
                    UsaDefaultCredentials = false

            };
        }
    }
}
