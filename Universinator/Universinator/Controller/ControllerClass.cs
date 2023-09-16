using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model;
using Universinator.Model.Interface;
using Universinator.Model.Repositories;
using Universinator.Model.Systems;
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

       
    }
}
