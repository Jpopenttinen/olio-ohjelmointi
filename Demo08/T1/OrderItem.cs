using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class OrderItem
    {

        public string Name { get; set; }
        public int Size { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public override string ToString()
        {
            return "Name: " + Name + "Size: " + Size;
        }
    }
}
