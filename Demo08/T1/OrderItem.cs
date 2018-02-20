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
        public int Stock { get; set; }

        public OrderItem(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Stock: " + Stock;
        }
    }
}
