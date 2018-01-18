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
            int rivi = 0;
            int luku1 = 0;
            Console.WriteLine("Give a number: ");
            luku1 = Convert.ToInt32(Console.ReadLine());
            int height = luku1 - 2;
            /*int firstLine = luku1 - 2;
            string first = new string(' ', firstLine);
            Console.WriteLine(first + "*");*/
            int emptyRow = height;
            int treeLegEmpty = height;
            //Top of the tree
            for (; height > 0;)
            {
                rivi++;

                string empty = new string(' ', emptyRow);
                string rivitys = new string('*', rivi);
                int secHalfRow = rivi - 1;
                string secHalfTree = new string('*', secHalfRow);
                Console.WriteLine(empty + rivitys + secHalfTree);
                height--;
                emptyRow--;
            }

            //Tree leg
            string rootEmpty = new string(' ', treeLegEmpty);
            char star = '*';
            Console.WriteLine(rootEmpty + star);
            Console.WriteLine(rootEmpty + star);

            Console.ReadLine();
        }
    }
}
