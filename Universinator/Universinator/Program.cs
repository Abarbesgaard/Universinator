using Universinator.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Universinator

{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            
            ControllerClass controller = new ControllerClass();

            controller.Load();
            Console.ReadLine();

            Console.Clear();
            controller.SetConsoleDisplayWidthAndHeight();
            
            controller.Run();
            
        }
    }
}