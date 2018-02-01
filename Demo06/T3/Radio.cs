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

        public bool OnOff { get; set; }
        public int Volume { get; set; }
        public float Frequency { get; set; }




    }
}
