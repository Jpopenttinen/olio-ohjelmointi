using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_2
{
    class Drinks : Product
    {
        public int Size { get; set; }


        public Drinks()
        {
        }

        public Drinks(int size, string name, DateTime date)
            : base(name, date)
        {
            Size = size;
        }
        public override string ToString()
        {
            return base.ToString() + "Size: " + Size;

        }


    }
}
