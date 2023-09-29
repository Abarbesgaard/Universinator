using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.PlanetModel;
using Universinator.Model.Sun;

namespace Universinator.Model.SolarSystem
{
    public record SolarSystemObject(
        string SystemName,
        bool IsActive,
        List<Planet> Planets,
        List<Star> Stars
        );
}
