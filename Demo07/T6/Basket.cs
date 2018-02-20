using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T6
{
    class Basket
    {

        public string Shape { get; set; }
        List<Item> Items = new List<Item>();

        public Basket()
        {
        }
        public void AddItems(string shape, List<Item> items)
        {
            Console.WriteLine("Basket is {0} shaped", shape);
            foreach (Item i in items)
            {
                Console.WriteLine(i);
            }

        }
        public override string ToString()
        {
            return "Shape: " + Shape;
        }
    }
}
