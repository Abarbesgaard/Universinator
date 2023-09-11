﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model;
using Universinator.View.Decorator;
using Universinator.View.LoadScreen;
using Universinator.View.ShipUI;

namespace Universinator.View
{

    public class MainMenu
    {
            private int menuOptionMin = 1;
            private int menuOptionMax = 3;

        public void DisplayMainMenu()
        {
            Banner banner = new Banner();
            Decorate decorate = new Decorate();
            banner.DisplayBanner();
            Console.WriteLine("MAIN MENU");

            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            ConsoleKeyInfo key;
            bool isSelected = false;

            #region menuLoop
            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Ship information\u001B[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Crew \u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorate.Decorating() : "   ")}Send out Probes\u001b[0m ");


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
                    ShipInformationMenu shipInformation = new ShipInformationMenu();
                    shipInformation.DisplayShipInformationMenu();
                    break;

                case 2:
                    Console.Clear();

                    break;


            }
            #endregion
        }

    }

}
