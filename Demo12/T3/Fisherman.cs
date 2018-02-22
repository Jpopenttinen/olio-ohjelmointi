using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Fisherman
    {
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public List<Fish> ListFish { get; set; }

        public Fisherman(string name, string phonenumber)
        {
            Name = name;
            Phonenumber = phonenumber;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Phonenumber: " + Phonenumber;
        }
    }
}
