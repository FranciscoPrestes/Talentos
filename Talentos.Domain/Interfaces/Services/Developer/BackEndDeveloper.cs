using System.Collections.Generic;
using System.Linq;
using Talentos.Domain.Entities;
using Talentos.Domain.Enum;


namespace Talentos.Domain.Interfaces.Services.Developer
{
    class BackEndDeveloper:IDeveloper
    {
        public bool Avalia(IEnumerable<Habilidade> habilidades)
        {
           var arrayHabilidades = habilidades as Habilidade[] ?? habilidades.ToArray();

            bool sabePython = Habilidade.Avalia(Tecnologias.Python, arrayHabilidades);
            bool sabeDjango = Habilidade.Avalia(Tecnologias.Django, arrayHabilidades);
            
            return (sabePython && sabeDjango);
            
        }
    }
}
