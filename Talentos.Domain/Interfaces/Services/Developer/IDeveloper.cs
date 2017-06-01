using System.Collections.Generic;
using Talentos.Domain.Entities;

namespace Talentos.Domain.Interfaces.Services.Developer
{
    public interface IDeveloper
    {
        bool Avalia(IEnumerable<Habilidade> habilidades);
    }
}
