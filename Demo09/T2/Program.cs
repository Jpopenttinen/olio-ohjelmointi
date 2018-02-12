using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {

            string song1 = "Toot";
            string song2 = "truut";
            string song3 = "pruut";
            string song4 = "tuut";
            string song5 = "Jee";
            string song6 = "Jippii";

            List<string> Sounds = new List<string>();

            Sounds.Add(song1);
            Sounds.Add(song2);
            Sounds.Add(song3);
            Sounds.Add(song4);
            Sounds.Add(song5);
            Sounds.Add(song6);


            CD cd = new CD
            (
            "Holidays",
            "best singer",
            Sounds
            );

            int k = 0;

            Console.WriteLine("CD Data: ");
            Console.WriteLine("CD Name: " + cd.Name);
            Console.WriteLine("Artist: " + cd.Artist);
            Console.WriteLine("Songs: ");
            foreach(string a in cd.Song)
            {
                k++;
                Console.WriteLine(k + ". " + a);
            }

            Console.ReadLine();

        }
    }
}
