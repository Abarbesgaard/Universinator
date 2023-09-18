using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Interface;
using Universinator.Model.PlanetModel;

namespace Universinator.Model.Repositories
{
    public class PlanetRepository : IObjectInterface
    {

        public List<Planet> _planets =  new List<Planet>();
        
        public void Add(int id)
        {
            Planet newplanet = Planet.GenerateRandomPlanet(id);
            _planets.Add(newplanet);
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
