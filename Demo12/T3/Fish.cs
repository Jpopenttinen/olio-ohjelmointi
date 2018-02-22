using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Fish
    {
        public string Pecies { get; set; }
        public int Lenght { get; set; }
        public int Weight { get; set; }
        public Location Fishlocation { get; set; }

        public Fish(string pecies, int lenght, int weight, Location fishlocation)
        {
            Pecies = pecies;
            Lenght = lenght;
            Weight = weight;
            Fishlocation = fishlocation;
        }
        public void PrintFishes()
        {
            Console.WriteLine("Specie: {0} {1} cm {2} kg", Pecies, Lenght, Weight);
            Console.WriteLine(Fishlocation);
        }


        public override string ToString()
        {
            string name = Fishlocation.Name;
            string loc = Fishlocation.Place;

            return "Pecie: " + Pecies + " " + Lenght + " cm " + Weight + " kg";
        }

    }
}
