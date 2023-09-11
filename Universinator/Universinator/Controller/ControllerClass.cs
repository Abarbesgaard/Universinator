﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.View;
using Universinator.View.LoadScreen;

namespace Universinator.Controller
{
    public class ControllerClass
    {
        StartMenu startMenu = new StartMenu();
        LoadScreen Screen = new LoadScreen();

        public void Run()
        {
            startMenu.DisplayStartMenu();
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
