using System.Collections.Generic;
using System.Linq;
using Talentos.Domain.Entities;
using Talentos.Domain.Enum;

namespace Talentos.Domain.Interfaces.Services.Developer
{
    class FrontEndDeveloper:IDeveloper
    {
        public bool Avalia(IEnumerable<Habilidade> habilidades)
        {
            var arrayHabilidades = habilidades as Habilidade[] ?? habilidades.ToArray();

            bool sabeHtml = Habilidade.Avalia(Tecnologias.HTML, arrayHabilidades);
            bool sabeCss = Habilidade.Avalia(Tecnologias.CSS, arrayHabilidades);
            bool sabeJavaScript = Habilidade.Avalia(Tecnologias.JavaScript, arrayHabilidades);


            return (sabeHtml && sabeCss && sabeJavaScript);

        }
    }
}
