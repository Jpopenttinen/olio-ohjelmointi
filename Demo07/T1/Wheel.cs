using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{

    interface IWheelsOn
    {
        void OnWheels();
    }

    class Wheel
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string WheelSize { get; set; }

        public Wheel (string brand, string type, string wheelSize)
        {
            Brand = brand;
            Type = type;
            WheelSize = wheelSize;

        }

        public override string ToString()
        {
            return ", Brand: " + Brand + ", Type: " + Type + ", WheelSize: " + WheelSize;
        }


    }
}
