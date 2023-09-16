using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Ship;
using Universinator.Model.Systems;

namespace Universinator.Controller
{
    public class PlayerController
    {
        public NavigationSystem navigationSystem = new NavigationSystem();
        private static PlayerController instance;
        private PlayerController() { }
        public static PlayerController GetInstance()
        {
            if (instance == null)
            {
                instance = new PlayerController();
            }
            return instance;
        }

        public void NavigationSystemShowCurrentPlanet()
        {
            navigationSystem.CurrentPlanet();
        }

    }
}
