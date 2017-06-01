using System.Collections.Generic;
using Talentos.Domain.Entities;
using Talentos.Domain.Enum;

namespace Talentos.MVC.ViewModels
{
    public class CandidaturaViewModel
    {
        public CandidatoViewModel Candidato { get; set; }
        public int Html { get; set; }
        public int Css { get; set; }
        public int JavaScript { get; set; }
        public int Python { get; set; }
        public int Django { get; set; }
        public int Android { get; set; }
        public int IOS { get; set; }

        public Candidato ConvertToModel()
        {
            var candidato = new Candidato();
            candidato.Nome = this.Candidato?.Nome;
            candidato.Email = this.Candidato?.Email;
         
            candidato.Habilidades = new List<Habilidade>()
            {
                new Habilidade()
                {
                    HabilidadeId = Tecnologias.HTML, 
                    Nivel = this.Html
                },
                new Habilidade()
                {
                    HabilidadeId = Tecnologias.CSS,
                    Nivel = this.Css
                },

                new Habilidade()
                {
                    HabilidadeId = Tecnologias.JavaScript,
                    Nivel = this.JavaScript
                },

                new Habilidade()
                {
                    HabilidadeId = Tecnologias.Python,
                    Nivel = this.Python
                },

               
                new Habilidade()
                {
                    HabilidadeId = Tecnologias.Django,
                    Nivel = this.Django
                },

                new Habilidade()
                {
                    HabilidadeId = Tecnologias.Android,
                    Nivel = this.Android
                },

                new Habilidade()
                {
                    HabilidadeId = Tecnologias.IOS,
                    Nivel = this.IOS
                }
            };


            return candidato;

        }
    }
}