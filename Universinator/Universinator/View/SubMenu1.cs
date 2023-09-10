using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.View.Decorator;

namespace Universinator.View
{
    public class SubMenu1
    {
        public void DisplaySubMenu1()
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

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Sub Menu 2\u001b[0m ");
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
            SubMenu2 subMenu2 = new SubMenu2();
            switch (option)
            {
                case 1:
                    Console.Clear();
                    subMenu2.DisplaySubMenu2();
                    break;

                case 2:
                    Console.Clear();

                    break;


            }
        }

    }
}

