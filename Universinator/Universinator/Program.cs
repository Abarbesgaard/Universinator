using Universinator.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Universinator.Model.Systems;
using System.Drawing;

namespace Universinator

{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ControllerClass controller = new ControllerClass();

            #region intro sequence
            //controller.Load();
            //Console.ReadLine();
            #endregion

            Console.Clear();
            
            controller.Run();

        }
            
    }
}