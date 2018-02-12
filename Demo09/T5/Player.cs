using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Shoot { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }

        public Player(int number, string lastName, string firstName, string position, string shoot)
        {
            FirstName = firstName;
            LastName = lastName;
            Shoot = shoot;
            Number = number;
            Position = position;
        }

        public override string ToString()
        {

            return FirstName + LastName + Shoot + Number + Position;
        }

    }
}
