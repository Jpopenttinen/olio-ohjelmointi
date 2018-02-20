using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Player
    {
        /*Tee Pelaaja-luokka, jolla on 
             * ominaisuudet: etunimi, sukunimi, pelipaikka (mv, p, h), 
             * kätisyys (L tai R).*/

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Shoot { get; set; }

        public Player(string firstName, string lastName, string position, string shoot)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Shoot = shoot;
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " Position: " + Position + " Shoot: " + Shoot;
        }
    }
}
