using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model
{
    public class Planet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Tilføj eventuelt flere egenskaber efter behov

        public Planet(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
