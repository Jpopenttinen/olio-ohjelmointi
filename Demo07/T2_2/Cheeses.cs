using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_2
{
    class Cheeses : Product
    {
        public string Shape { get; set; }

        public Cheeses()
        {

        }

        public Cheeses(string shape, string name, DateTime date)
            :base (name, date)
        {
            Shape = shape;
        }

        public override string ToString()
        {
            return base.ToString() + "Shape: " + Shape;

        }


    }
}
