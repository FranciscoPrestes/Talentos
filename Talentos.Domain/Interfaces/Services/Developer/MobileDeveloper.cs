using System.Collections.Generic;
using System.Linq;
using Talentos.Domain.Entities;
using Talentos.Domain.Enum;

namespace Talentos.Domain.Interfaces.Services.Developer
{
    class MobileDeveloper : IDeveloper
    {
        public bool Avalia(IEnumerable<Habilidade> habilidades)
        {
            var arrayHabilidades = habilidades as Habilidade[] ?? habilidades.ToArray();

            bool sabeAndroid = Habilidade.Avalia(Tecnologias.Android, arrayHabilidades);
            bool sabeIOS = Habilidade.Avalia(Tecnologias.IOS, arrayHabilidades);

            return (sabeAndroid || sabeIOS);
        }
    }
}
