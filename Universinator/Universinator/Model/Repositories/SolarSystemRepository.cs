using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.PlanetModel;
using Universinator.Model.SolarSystem;
using Universinator.Model.Sun;

namespace Universinator.Model.Repositories
{
    public class SolarSystemRepository : ISolarSystem
    {
        private List<SolarSystemObject> solarSystems = new List<SolarSystemObject>();

        public void Add(SolarSystemObject solarSystem)
        {
            solarSystems.Add(solarSystem);
        }

        public int Planets()
        {
            throw new NotImplementedException();
        }

        public string StarCoreInformation()
        {
            throw new NotImplementedException();
        }

        public string StarName()
        {
            throw new NotImplementedException();
        }
    }
}
