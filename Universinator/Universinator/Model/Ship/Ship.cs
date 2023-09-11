using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model.Ship
{
    public class Ship
    {
        public float ShipSpeed { get; set; }
        public string Course { get; set; }

        public string NavigationSystem { get; set; }
        public string LifeSupportSystem { get; set; }
        public string CommunicationSystem { get; set; }
        private static Ship instance;

        


        private Ship() { }
        public static Ship GetInstance()
        {
            if (instance == null)
            {
                instance = new Ship();
            }
            return instance;
        }
        public void NavigationDisplay()
        {
            Course = "XannuVII";
            Console.WriteLine("|---------|---------->");
            Console.WriteLine("| Speed   |" + ShipSpeed.ToString() + " Km/t");
            Console.WriteLine("|---------|---------->");
            Console.WriteLine("|---------|---------->");
            Console.WriteLine("| Course  |" + Course );
            Console.WriteLine("|---------|---------->");

        }
        
        public float ChangeSpeedOfShip(float shipSpeed)
        {
            this.ShipSpeed = shipSpeed;
            return ShipSpeed;
        }

        public void ShipView()
        {
            Console.WriteLine("    __                    ");
            Console.WriteLine("    | \\                  ");
            Console.WriteLine("    = [_ | H)--._____     ");
            Console.WriteLine("    = [+--, -------'      ");
            Console.WriteLine("     [| _ / \"\"          ");
            Console.WriteLine("                          ");
        }

        public void ShipTypeInformation()
        {
            Console.WriteLine("This is a XaewinSchenu ship. Its value is approximately: 3400¤");
        }

        
    }
}
