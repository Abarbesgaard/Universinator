using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model.PlanetModel
{
    public class Planet
    {
        public int ID { get; set; }

        public string PlanetType { get; set; }

        public EPlanetTemperature PlanetTemperature { get; set; }

        public EPlanetAtmosphere PlanetAtmosphere { get; set; }

        public string PlanetFauna { get; set; }

        public string PlanetFlora { get; set; }

        // Tilføj eventuelt flere egenskaber efter behov

        public Planet(int id, string planetType, EPlanetTemperature planetTemperature, EPlanetAtmosphere planetAtmosphere, string planetFauna, string planetFlora)
        {
            ID = id;
            PlanetType = planetType;
            PlanetTemperature = planetTemperature;
            PlanetAtmosphere = planetAtmosphere;
            PlanetFauna = planetFauna;
            PlanetFlora = planetFlora;

        }


        public static Planet GenerateRandomPlanet(int id)
        {
            Random random = new Random();

            string[] planetTypes = { "Terrestrial", "Gas Giant", "Ice Giant", "Dwarf Planet" };
            EPlanetTemperature randomTemperature = (EPlanetTemperature)random.Next(Enum.GetValues(typeof(EPlanetTemperature)).Length);
            EPlanetAtmosphere randomAtmosphere = (EPlanetAtmosphere)random.Next(Enum.GetValues(typeof(EPlanetAtmosphere)).Length);
            string[] planetFauna = { "High biodiversity", "Low biodiversity", "No fauna" };
            string[] planetFlora = { "Lush vegetation", "Sparse vegetation", "No vegetation" };

            string randomPlanetType = planetTypes[random.Next(0, planetTypes.Length)];

            return new Planet(
                id,
                randomPlanetType,
                randomTemperature,
                randomAtmosphere,
                planetFauna[random.Next(0, planetFauna.Length)],
                planetFlora[random.Next(0, planetFlora.Length)]
            );
        }
    }
}
