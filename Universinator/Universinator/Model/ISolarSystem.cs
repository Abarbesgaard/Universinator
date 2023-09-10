using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model
{
    public interface ISolarSystem
    {

        string StarName();
        string StarCoreInformation();

        int Planets();

    }
}
