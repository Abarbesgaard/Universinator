using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.View.Decorator;

namespace Universinator.View
{
    public class StartMenu
    {
        private int menuOptionMin = 1;
        private int menuOptionMax = 3;
        public void DisplayStartMenu()
        {
            Banner banner = new Banner();
            Decorate decorate = new Decorate();
            banner.DisplayBanner();

            
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            ConsoleKeyInfo key;
            bool isSelected = false;
            
            
            #region menuLoop
            while (!isSelected)
            {
            
                Console.SetCursorPosition(left, top);
                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Start\u001B[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Options\u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorate.Decorating() : "   ")}Quit\u001b[0m ");


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
            MainMenu mainMenu = new MainMenu();
            switch (option)
            {
                case 1:
                    Console.Clear();
                    mainMenu.DisplayMainMenu();
                    break;

                case 2:
                    Console.Clear();
                    // Options Menu here
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;


            }
            #endregion
        }
    }
}
