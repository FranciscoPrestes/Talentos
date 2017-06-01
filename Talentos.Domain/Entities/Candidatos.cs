using System;
using System.Collections.Generic;

namespace Talentos.Domain.Entities
{
   public class Candidato
    {
        public int CandidatoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<Habilidade> Habilidades { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
