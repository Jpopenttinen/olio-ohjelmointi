using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T6
{
    class Item
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }

        public Item(string name, int size, string type)
        {
            Name = name;
            Size = size;
            Type = type;

        }
        public override string ToString()
        {
            return "Name: " + Name + " Size: " + Size + " Type: " + Type;
        }

    }
}
