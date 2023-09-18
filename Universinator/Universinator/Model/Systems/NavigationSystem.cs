using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.PlanetModel;
using Universinator.Model.Repositories;

namespace Universinator.Model.Systems
{
    public class NavigationSystem
    {
        private PlanetRepository _planetRepo = new PlanetRepository();
        private Planet _currentPlanet = null;
        public void CurrentPlanet()
        {
            
            Planet currentPlanet = _planetRepo.GetPlanetByID(1);

            if (currentPlanet != null)
            {
                Console.WriteLine("Current Planet Details:");
                Console.WriteLine($"ID: {currentPlanet.ID}");
                Console.WriteLine($"Type: {currentPlanet.PlanetType}");
                Console.WriteLine($"Temperature: {currentPlanet.PlanetTemperature}");
                Console.WriteLine($"Atmosphere: {currentPlanet.PlanetAtmosphere}");
                Console.WriteLine($"Fauna: {currentPlanet.PlanetFauna}");
                Console.WriteLine($"Flora: {currentPlanet.PlanetFlora}");
            }
           
        }
        public void InitializeRepositoryWithDefaultPlanet()
        {
            if (_currentPlanet == null) // Only generate a new planet if one doesn't already exist
            {
                _currentPlanet = Planet.GenerateRandomPlanet(1);
                _planetRepo.Add(_currentPlanet);
            }
        }

        public void TravelToNewPlanet(int id)
        {
            _currentPlanet = _planetRepo.GetPlanetByID(id);
        }

        //private SolarSystem solarSystem;

        //private PropulsionSystem propulsionSystem;

        //public SolarSystem SolarSystem()
        //{
        //    return ?;
        //}

        //public float calculateTravelTime()
        //{
        //    return?;
        //}

        //public void TravelToPlanet( Planet destination)
        //{

        //}
        //public void TravelToSolarSystem( SolarSystem destination)
        //{

        //}
    }
}
