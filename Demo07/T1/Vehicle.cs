using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Vehicle
    {


        public string Name { get; set; }
        public string Model { get; set; }

        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;

        }

        public override string ToString()
        {
            return ", Name: " + Name + ", Model: " + Model;
        }

    }
}
