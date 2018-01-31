using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Bike : Vehicle
    {

        // vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi

        public bool Gears { get; set; }
        public string GearModel { get; set; }


        public Bike(string name, string model, int year, string color, bool gears, string gearModel)
            :base (name, model, year, color)
        {
            
            if (gears == true)
            {
                Gears = gears;
                GearModel = gearModel;
            }
            else
            {
                GearModel = null;
            }

            
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Year: " + Year + ", Color: " + Color + ", Gears: " + Gears + ", GearModel: " + GearModel;

        }

    }
}
