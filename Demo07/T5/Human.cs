using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5
{
    class Human : Mammal
    {

        /*Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen 
         * yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). Lisää 
         * Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa 
         * ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. Huomioi, 
         * että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa*/

        private int age;
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public override int Age
        {
            get { return age; }
        }

        public Human(string name, int weight, int height)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Weight: " + Weight + " Height: " + Height;
        }
        public override void Move()
        {
            Console.WriteLine("Moooove!");
        }
        public void Grow()
        {
            age += 1;
        }
    }
}
