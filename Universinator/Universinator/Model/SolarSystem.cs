using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model
{
    public class SolarSystem : ISolarSystem
    {
        private int _possiblePlanets = 10;
        public string StarName()
        {
            string StarName = "Xenusia XI";
            return StarName;
        }

        public string StarCoreInformation()
        {
            string StarCore = "Molten Iron";
            return StarCore;
        }

        public int Planets()
        {
            var random = new Random();
            int numberOfPlanets = random.Next(0, _possiblePlanets);
            
            return numberOfPlanets;
        }
    }
}
