using System.Collections.Generic;
using System.Linq;

namespace Talentos.Domain.Entities
{
    public class Habilidade
    {
        public int HabilidadeId { get; set; }
        public int Nivel { get; set; }

        public int TecnologiaId { get; set; }

        public int CandidatoId { get; set; }

        public virtual Candidato Candidato { get; set; }

        public static bool Avalia(int idHabilidade, IEnumerable<Habilidade> habilidades, int notaDeCorte = 7)
        {
            return habilidades.Single(h => h.HabilidadeId == idHabilidade)?.Nivel >= notaDeCorte;
        }
    }
}
