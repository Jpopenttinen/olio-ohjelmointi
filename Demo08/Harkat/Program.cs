using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            bool result = false;
            Random rand = new Random();

            

            // ask numbers
            do
            {
                // ask number from the user (read one line)
                Console.Write("Give a number > ");
                string line = Console.ReadLine();
                // try to read number from the given line
                //Random rnd = new Random();
                int number; // =  rnd.Next(1,10);
                result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    list.Add(number);
                }
                //76if (number == 10) { break; }
            } while (result);


            for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                if (i == (list.Count - 1))
                {

                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine(number + ",");

                }
            }
            Console.WriteLine("Average : {0}", list.Average());
            Console.WriteLine("Min : {0}", list.Min());
            Console.WriteLine("Max : {0}", list.Max());
            Console.WriteLine("Numbers count : {0}", list.Count);

            list.Sort();
            list.ForEach(item => Console.Write(item + ","));

            Console.ReadLine();

        }


    }
}
