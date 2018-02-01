using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Radio
    {
        // päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja 
        // kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0)


        private bool onOff;
        public bool OnOff
        {
            get { return onOff; }

            set {

                if (value == true)
                    {
                    onOff = true;
                    }
                else { onOff = false; }

                }
        }

        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value < 10)
                    {
                    volume = value;
                    }
                else { Console.WriteLine("Given value isn't in a volume range"); }
            }
        }
        private float frequency;
        public float Frequency
        {
            get { return frequency; }
            set { if (value >= 2000 && value <= 26000) { frequency = value; } }
        }




    }
}
