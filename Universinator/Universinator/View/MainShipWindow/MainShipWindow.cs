using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Repositories;
using Universinator.Model;
using Universinator.Model.SolarSystem;
using Universinator.Model.PlanetModel;

namespace Universinator.View.MainShipWindow
{
    public class MainShipWindow
    {
            static Dictionary<string, Action> commandDictionary = new Dictionary<string, Action>()
        {
            { "_sys.cln",            Clean },
            { "_sys.Scan_star.tlm",  ScanStar },
            { "_sys.Help.txt",       Help },
            { "_sys.back",           Back }

            // Tilføj flere kommandoer og deres handlinger her
        };
            bool shouldContinue = true;
        public void MainShipWindowDisplay()
        {
            Console.Clear();
            Console.WriteLine("write _sys.Help.txt to see available commands");

            while (shouldContinue)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();

                // Tjekker om brugeren ønsker at afslutte programmet
                if (input == "_sys.Terminate")
                {
                    shouldContinue = false;
                }
                else if (commandDictionary.ContainsKey(input))
                {
                    commandDictionary[input]();
                }
                else
                {
                    Console.WriteLine("UKWN CMD");
                }
            }
        }
        static void Clean()
        {
            Console.Clear();
            Console.WriteLine("write _sys.Help.txt to see available commands");
        }

        static void ScanStar()
        {
            Console.Clear();
            Console.WriteLine("write _sys.Help.txt to see available commands");

            ISolarSystem solarSystem = new SolarSystemRepository();

            solarSystem.StarName();
            
            Console.WriteLine("");

        }
        static void Help()
        {
            Console.Clear();
            Console.WriteLine("The following commands are available: \n");
            foreach (var command in commandDictionary.Keys)
                Console.WriteLine(command.ToString());
        }
        static void Back()
        {
            Console.Clear();
            GameMenu gameMenu = new GameMenu();
            gameMenu.DisplayGameMenu();
        }

    }
}
