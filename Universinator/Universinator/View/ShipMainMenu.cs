using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model;
using Universinator.Model.Ship;
using Universinator.View.Decorator;
using Universinator.View.LoadScreen;
using Universinator.View.Navigation;
using Universinator.View.ShipData;


namespace Universinator.View
{

    public class ShipMainMenu
    {
            private int menuOptionMin = 1;
            private int menuOptionMax = 9;

        public void DisplayMainMenu()
        {
            Banner banner = new Banner();
            Decorate decorate = new Decorate();
            banner.DisplayBanner();

            //INdsæt interface her istedet senere
            Ship ship = Ship.GetInstance();
            ship.ShipView();

            
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            ConsoleKeyInfo key;
            bool isSelected = false;

            #region menuLoop
            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Ship information\u001B[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Navigation \u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorate.Decorating() : "   ")}Crew  \u001b[0m ");
                Console.WriteLine($"{(option == 4 ? decorate.Decorating() : "   ")}Life Support \u001b[0m ");
                Console.WriteLine($"{(option == 5 ? decorate.Decorating() : "   ")}Communication \u001b[0m ");
                Console.WriteLine($"{(option == 6 ? decorate.Decorating() : "   ")}Cargo and payload Deployment \u001b[0m ");
                Console.WriteLine($"{(option == 7 ? decorate.Decorating() : "   ")}Science and Research Equipment \u001b[0m ");
                Console.WriteLine($"{(option == 8 ? decorate.Decorating() : "   ")}Propulsion Systems \u001b[0m ");
                Console.WriteLine($"{(option == 9 ? decorate.Decorating() : "   ")}Power and Energy Systems \u001b[0m ");


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
                    ShipDataMenu shipData = new ShipDataMenu();
                    shipData.DisplayShipInformationMenu();
                    break;

                case 2:
                    Console.Clear();
                    NavigationMenu navigationMenu = new NavigationMenu();
                    navigationMenu.NavigationDisplay();
                    break;
                case 3:
                    Console.Clear();

                    break;
                case 4:
                    Console.Clear();

                    break;
                case 5:
                    Console.Clear();

                    break;
                case 6:
                    Console.Clear();

                    break;
                case 7:
                    Console.Clear();

                    break;
                case 8:
                    Console.Clear();

                    break;
                case 9:
                    Console.Clear();

                    break;


            }
            #endregion
        }

    }

}
