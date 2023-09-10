using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.View.Decorator;

namespace Universinator.View
{
    public class SubMenu2
    {
        public void DisplaySubMenu2()
        {
            Banner banner = new Banner();
            banner.DisplayBanner();


            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            Decorate decorate = new Decorate();
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Sub Menu 3\u001b[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Go back\u001b[0m ");


                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 2 : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == 2 ? 1 : option + 1;
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
            SubMenu3 subMenu3 = new SubMenu3();
            subMenu3.DisplaySubMenu3();
                    
                    break;

                case 2:
                    Console.Clear();

                    break;


            }
        }

    }
}

