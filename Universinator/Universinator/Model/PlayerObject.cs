using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universinator.Model.Ship;
using Universinator.Model.Systems;

namespace Universinator.Model
{
    public class PlayerObject
    {
        public NavigationSystem navigationSystem = new NavigationSystem();
        private static PlayerObject instance;
        private PlayerObject() { }
        public static PlayerObject GetInstance()
        {
            if (instance == null)
            {
                instance = new PlayerObject();
            }
            return instance;
        }

        public void NavigationSystemShowCurrentPlanet()
        {
            navigationSystem.CurrentPlanet();
        }

    }
}
