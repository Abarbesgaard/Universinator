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

        public string ChangeCourse(string course)
        {
            this.Course = course;
            return Course;
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

        public void OverView()
        {
           
            Console.WriteLine("                                       ");
            Console.WriteLine("                      ╔════╗           ");
            Console.WriteLine("            ╔════╦════╣   ⌂║           ");
            Console.WriteLine("            ║ö   σ    ║    ║           ");
            Console.WriteLine("         ╔══╬═══σ╬══╦σ╩═══σ╩╦════╦════╗");
            Console.WriteLine("         ║  σ    ║██║  ¥    σ    ║   C║");
            Console.WriteLine("         ║  σ   ¢║██║       ║ Φ  σ   C║");
            Console.WriteLine("         ╚══╬═══σ╬══╩σ╦═══σ╦╩════╩════╝");
            Console.WriteLine("            ║    σ    ║    ║           ");
            Console.WriteLine("            ╚════╩════╣    ║           ");
            Console.WriteLine("                      ╚════╝           ");
            Console.WriteLine("σ: Door");
            Console.WriteLine("ö: Oxygen Systems ");
            Console.WriteLine("¢: Propulsion Systems ");
            Console.WriteLine("¥: Life Support Systems ");
            Console.WriteLine("Φ: Communication Systems ");
            Console.WriteLine("C: Navigation Systems ");



        }
    }
}
