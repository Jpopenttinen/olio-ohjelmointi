using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Location
    {
        public string Name { get; set; }
        public string Place { get; set; }

        public Location(string name, string place)
        {
            Name = name;
            Place = place;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Place: " + Place;
        }

    }
}
