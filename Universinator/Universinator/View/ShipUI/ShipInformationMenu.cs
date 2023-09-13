using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Ship;
using Universinator.View.Decorator;

namespace Universinator.View.ShipUI
{
    public class ShipInformationMenu
    {
        private int menuOptionMin = 1;
        private int menuOptionMax = 3;

        public void DisplayShipInformationMenu()
        {
            Banner banner = new Banner();
            Decorate decorate = new Decorate();
            banner.DisplayBanner();
            Console.WriteLine("SHIP INFORMATION");

            /*
             * Her skal være kode der generere information omkring status på de forskellige ting på skibet
             */
            #region Ship information display
            Ship ship = Ship.GetInstance();
            
            ship.ShipView();

            ship.OverView();

            ship.ShipTypeInformation();
            Console.WriteLine("");
            ship.NavigationDisplay();

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
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}TEMP \u001b[0m ");
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
            ExploreMenu exploreMenu = new ExploreMenu();
            switch (option)
            {
                case 1:
                    Console.Clear();
                    ChangeSpeed changeSpeed = new ChangeSpeed();
                    changeSpeed.ChangeSpeedDisplay();

                    break;

                case 2:
                    Console.Clear();

                    break;
                case 3:
                    Console.Clear();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.DisplayMainMenu();
                    break;


            }
            #endregion
        }
    }
}
