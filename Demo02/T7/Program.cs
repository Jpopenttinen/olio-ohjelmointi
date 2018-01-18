using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 50, 10, 75, 8, 100 };
            int[] numbers2 = { 7, 32, 47, 11, 2 };
            int[] numbers3 = new int[numbers1.Length + numbers2.Length];
            Array.Copy(numbers1, numbers3, numbers1.Length);
            Array.Copy(numbers2, 0, numbers3, numbers1.Length, numbers2.Length);

            // sorting
            Array.Sort(numbers3);

            Console.WriteLine("Numbers in an array nro 1: " + numbers1[0] + ", "  + numbers1[1] + ", " + numbers1[2] + ", " + numbers1[3] + ", " + numbers1[4]);
            Console.WriteLine("Numbers in an array nro 1: " + numbers2[0] + ", " + numbers2[1] + ", " + numbers2[2] + ", " + numbers2[3] + ", " + numbers2[4]);
            

            for (int i = numbers3.GetLowerBound(0); i <= numbers3.GetUpperBound(0);
                i++)
                {
                    Console.WriteLine("   [{0}] : {1}", i, numbers3[i]);
                }
            Console.ReadLine();
        }
    }
}
