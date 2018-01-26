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
            if (ItMath.Date() == 1)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("Not so proper Date!");

            Console.ReadLine();

        }
    }
}
