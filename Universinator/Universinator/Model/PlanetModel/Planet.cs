using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model.PlanetModel
{
    public record Planet
        (
        string PlanetName, 
        bool IsActive, 
        PlanetDescription PlanetDescription 
        );
}
