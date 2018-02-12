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

            List<string> Cards = new List<string>();
            /*List<string> Diamonds = new List<string>();
            List<string> Hearts = new List<string>();
            List<string> Spades = new List<string>();*/

            //Clubs
            string club = "Club#";
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(string.Concat(club, i));
            }
            //Diamonds
            string diamond = "Diamond#";
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(string.Concat(diamond, i));
            }
            //Hearts
            string heart = "Heart#";
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(string.Concat(heart, i));
            }
            //Spades
            string spade = "Spade#";
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(string.Concat(spade, i));
            }

            int n = 0;
            foreach (string b in Cards)
            {
                n++;
                Console.WriteLine(n + " card is " + b);  // TEHTÄVÄ 3
            }


            Console.WriteLine(" ");
            Console.WriteLine("TEHTÄVÄ 4!!!!");
            Console.WriteLine(" ");

            List<string> Shuffled = new List<string>();

            Shuffled = CardShuffle.Fisher_Yates_CardDeck_Shuffle(Cards);
            int k = 0;
            foreach (string b in Shuffled)
            {
                k++;
                Console.WriteLine(k + " card is " + b);  // TEHTÄVÄ 4
            }
            Console.ReadLine();
        }
       
    }
}
