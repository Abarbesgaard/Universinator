using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Ship;
using Universinator.View.Decorator;
using Universinator.View.Navigation;

namespace Universinator.View.ShipData
{
    public class ShipDataMenu
    {
        private int menuOptionMin = 1;
        private int menuOptionMax = 3;

        public void DisplayShipInformationMenu()
        {
            Banner banner = new Banner();
            Decorate decorate = new Decorate();
            banner.DisplayBanner();
            Console.WriteLine("SHIP INFORMATION");

            #region Ship information display
            Ship ship = Ship.GetInstance();
            //ship.NavigationDisplay();
            Console.WriteLine("\nAll systems are Operational");
            Console.WriteLine("═══════════════════════════");

            ship.OverView();
            ship.ShipTypeInformation();
            //Console.WriteLine("");

            #endregion


            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            ConsoleKeyInfo key;
            bool isSelected = false;

            #region menuLoop
            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Change Speed\u001B[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Change Course \u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorate.Decorating() : "   ")}Back to Control\u001b[0m ");


                key = Console.ReadKey(false);


                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == menuOptionMin ? menuOptionMax : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == menuOptionMax ? menuOptionMin : option + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;

                        break;
                }
            }
            
            switch (option)
            {
                case 1:
                    Console.Clear();
                    

                    break;

                case 2:
                    Console.Clear();
                        // Change Course screen
                    break;
                case 3:
                    Console.Clear();
                    ShipMainMenu mainMenu = new ShipMainMenu();
                    mainMenu.DisplayMainMenu();
                    break;


            }
            #endregion
        }
    }
}
