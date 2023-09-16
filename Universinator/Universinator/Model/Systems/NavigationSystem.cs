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
        private PlanetRepository planetRepo;

        //private SolarSystem solarSystem;

        //private PropulsionSystem propulsionSystem;
        public NavigationSystem(PlanetRepository repo)
        {
            planetRepo = repo;
        }


        public Planet CurrentPlanet()
        {
            Planet planet = new Planet(1,"Xexu","A planet of splendor");
            planetRepo.Add(planet);
            return planet;
        }


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
