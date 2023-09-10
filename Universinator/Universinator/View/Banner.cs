using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.View
{
    public class Banner
    {
        public void DisplayBanner()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("UNIVERSINATOR                                    ");
            Console.ResetColor();
        }
    }
}
