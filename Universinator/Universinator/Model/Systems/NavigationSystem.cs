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
        public void ActivePlanet()
        {
            // Denne skal finde ud af om spilleren er på planet på en liste, planeten på denne liste har en true i IsActive
            
           
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
