using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Repositories;

namespace Universinator.Model.Systems
{
    public class NavigationSystem
    {
        private PlanetRepository _planetRepo = new PlanetRepository();

        public void CurrentPlanet()
        {
            Planet planet = new Planet(1,"name", "Desc");
            Console.WriteLine(planet.Name.ToString() + planet.Description.ToString());
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
