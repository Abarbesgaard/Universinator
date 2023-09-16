using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Controller;
using Universinator.Model.Repositories;
using Universinator.Model.Systems;
using Universinator.View.Decorator;

namespace Universinator.View.Navigation
{
    public class ActiveSolarSystemOverViewMenu
    {
        private int menuOptionMin = 1;
        private int menuOptionMax = 4;
        private string userInput = "";

        public void ActiveSolarSystemOverViewDisplay()
        {
            Banner banner = new Banner();
            Decorate decorate = new Decorate();
            PlayerController playerController = PlayerController.GetInstance();
            banner.DisplayBanner();
            Console.WriteLine("Our ship is currently at: planet1 ^");

            PlanetRepository repo = new PlanetRepository();
            NavigationSystem navSystem = new NavigationSystem(repo);

            string name = navSystem.CurrentPlanet().Name;


            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            ConsoleKeyInfo key;
            bool isSelected = false;
            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Details\u001B[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Go Back \u001b[0m ");




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
                    NavigationMenu navigationMenu = new NavigationMenu();
                    navigationMenu.NavigationDisplay();
                    break;
            }
        }
    }
}

