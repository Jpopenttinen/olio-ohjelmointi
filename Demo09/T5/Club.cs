using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5
{
    class Club
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; set; }

        public Club(string name, string city, List<Player> players)
        {
            Name = name;
            City = city;
            Players = players;
        }

        public override string ToString()
        {
            foreach (Player a in Players)
            {
                return a.FirstName + a.LastName + a.Number + a.Shoot + a.Position;
            }
            return Name + City;
        }


    }
}
