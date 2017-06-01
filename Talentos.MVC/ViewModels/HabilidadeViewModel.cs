using Talentos.Domain.Entities;
using Talentos.Domain.Entities.ValueObjects;

namespace Talentos.MVC.ViewModels
{
    public class HabilidadeViewModel
    {
        public int HabilidadeId { get; set; }
        public int Nivel { get; set; }

        public int TecnologiaId { get; set; }

        public Tecnologia Tecnologia { get; set; }

        public int CandidatoId { get; set; }

        public Candidato Candidato { get; set; }
    }

}