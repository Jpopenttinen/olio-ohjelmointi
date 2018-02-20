using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Jukka", 85, 190);
            Baby baby = new Baby("Pampers", "Liisa", 20, 90);
            Adult adult = new Adult("Toyota", "Matti", 80, 177);

            Console.WriteLine("Baby age is now: " + baby.Age);

            adult.Move();
            baby.Move();
            for (int i = 0; i < 5; i++)
            {
                baby.Grow();
            }

            Console.WriteLine("Baby age is now: " + baby.Age);

        }
    }
}
