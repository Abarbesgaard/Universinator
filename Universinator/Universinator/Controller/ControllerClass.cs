using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.View;

namespace Universinator.Controller
{
    public class ControllerClass
    {
        MainMenu MainMenu = new MainMenu();
        LoadScreen Screen = new LoadScreen();

        public void Run()
        {
            MainMenu.DisplayMainMenu();
        }

        public void Load()
        {
            Screen.LoadScreenDisplay();
        }

        public void SetConsoleDisplayWidthAndHeight()
        {
            Console.SetWindowSize(80, 30);
            Console.SetBufferSize(80, 30);
            Console.SetWindowPosition(0, 0);
        }
    }
}
