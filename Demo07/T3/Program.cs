using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Jääkiekon SM-liigassa on viisitoista joukkuetta ja jokaisessa 
             * joukkuuessa on noin 25 pelaajaa. Tee Pelaaja-luokka, jolla on 
             * ominaisuudet: etunimi, sukunimi, pelipaikka (mv, p, h), 
             * kätisyys (L tai R). Luo myös luokka Seura, jolla on ominaisuudet: 
             * nimi, kaupunki ja kokoelma Pelaaja-olioita. Tee konsoli sovellus, 
             * joka osaa esittää valitun seuran pelaajat. Voit "kovakoodata" 
             * pelaajatiedot pelaajaolioihin.*/

            Player goalie = new Player("Jukka", "Mattila", "mv", "L");
            Player defencemen1 = new Player("Esa", "Kallela", "p", "L");
            Player defencemen2 = new Player("Jukka", "Laamanen", "mv", "L");
            Player forward1 = new Player("Marri", "Kärki", "h", "R");
            Player forward2 = new Player("Sami", "Närhi", "h", "L");
            Player forward3 = new Player("Kalle", "Joku", "h", "L");

            List<Player> line = new List<Player>();
            line.Add(goalie);
            line.Add(defencemen1);
            line.Add(defencemen2);
            line.Add(forward1);
            line.Add(forward2);
            line.Add(forward3);

            Club Jypppi = new Club();
            Jypppi.CreateClub("JYP", "Jypinkylä", line);

        }
    }
}
