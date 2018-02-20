using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Club
    {
        /*Luo myös luokka Seura, jolla on ominaisuudet: 
             * nimi, kaupunki ja kokoelma Pelaaja-olioita.*/

        public string Name { get; set; }
        public string City { get; set; }
        List<Player> Players = new List<Player>();

        public void CreateClub(string name, string city, List<Player> players)
        {
            Name = name;
            City = city;
            Players = players;

            Console.WriteLine("Club name: " + Name);
            Console.WriteLine("Club city: " + City);
            foreach (Player i in Players)
            {
                Console.WriteLine("Player: " + i);
            }

        }



    }
}
