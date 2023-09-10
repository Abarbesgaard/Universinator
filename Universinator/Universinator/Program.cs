using Universinator.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator

{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ControllerClass controller = new ControllerClass();
            controller.SetConsoleDisplayWidthAndHeight();
            
            controller.Run();
        }
    }
}