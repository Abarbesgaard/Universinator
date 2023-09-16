using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Universinator.Controller;
using Universinator.Model.Ship;
using Universinator.View.Decorator;


namespace Universinator.View.Navigation
{
    public class NavigationMenu
    {
        private int menuOptionMin = 1;
        private int menuOptionMax = 4;
        private string userInput = "";

        public void NavigationDisplay()
        {
            Banner banner = new Banner();
            Decorate decorate = new Decorate();
            banner.DisplayBanner();
            Console.WriteLine("SHIP INFORMATION");



            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            ConsoleKeyInfo key;
            bool isSelected = false;
            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Active Solar System Overview\u001B[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Navigation \u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorate.Decorating() : "   ")}Crew  \u001b[0m ");
                Console.WriteLine($"{(option == 4 ? decorate.Decorating() : "   ")}Go Back \u001b[0m ");
               



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
                    ActiveSolarSystemOverViewMenu activeSolarSystemOverViewMenu = new ActiveSolarSystemOverViewMenu();
                    activeSolarSystemOverViewMenu.ActiveSolarSystemOverViewDisplay();
                    break;

                case 2:
                    Console.Clear();

                    break;
                case 3:
                    Console.Clear();

                    break;
                case 4:
                    Console.Clear();

                    break;
            }
        }
    }
}
