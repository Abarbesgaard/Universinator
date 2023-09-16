using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Interface;

namespace Universinator.Model.Repositories
{
    public class PlanetRepository : IObjectInterface
    {
        private List<Planet> _planets;
        public void Add(Planet planet) 
        { 
            _planets.Add(planet);
        }
        public void Remove(Planet planet)
        {
            _planets.Remove(planet);
        }
        public void Update(Planet planet) { }
        public void Delete(Planet planet) { }

        public Planet GetPlanetByID(int id)
        { 
            return _planets.FirstOrDefault(planet => planet.ID == id);
        }



    }
}
