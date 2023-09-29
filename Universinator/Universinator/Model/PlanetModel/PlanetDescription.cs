using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model.PlanetModel
{
    public record PlanetDescription(
        string PlanetName, 
        string PlanetType, 
        float PlanetGravity, 
        EPlanetTemperature PlanetTemperature, 
        EPlanetAtmosphere PlanetAtmosphere, 
        string PlanetFauna, 
        string PlanetFlora);
}
