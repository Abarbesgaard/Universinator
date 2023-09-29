using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.View.MainShipWindow
{
    public class GameMenu
    {
        static Dictionary<string, Action> commandDictionary = new Dictionary<string, Action>()
        {
            { "_sys.cln",            Clean },
            { "_sys.Open_Main.tlm",  OpenMain },
            { "_sys.Help.txt",       Help },
            { "_sys.Terminate",      AnotherCommand }

            // Tilføj flere kommandoer og deres handlinger her
        };
        bool shouldContinue = true;
        public void DisplayGameMenu()
        {
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

        static void Help()
        {
            Console.Clear();
            Console.WriteLine("The following commands are available: \n");
            foreach (var command in commandDictionary.Keys)
                Console.WriteLine(command.ToString());
        }
        static void AnotherCommand()
        {
            Console.WriteLine("Udfører en anden kommando...");
        }

        static void OpenMain()
        {
            Console.WriteLine("Opens");
            MainShipWindow mainShipWindow = new MainShipWindow();
            mainShipWindow.MainShipWindowDisplay();

        }
    }
}
