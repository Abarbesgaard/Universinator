using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.View.Decorator
{
    public class Decorate
    {
        public string Decorating() 
        {
            var decorator = ">  \u001b[33m";
            return decorator;
        }  
    }
}
