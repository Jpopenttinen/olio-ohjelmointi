using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] piste = new string[5];
            int j = 0;
            int[] points = new int[5];
            for (int i = 0; i < piste.Length; i++)
            {
                Console.WriteLine("Give a point: ");
                piste[i] = Console.ReadLine();
                Int32.TryParse(piste[i], out points[i]);
            }

            int min = points.Min();
            int minIndex = Array.IndexOf(points, min);

            points = points.Where((val, idx) => idx != minIndex).ToArray();

            int max = points.Max();
            int maxIndex = Array.IndexOf(points, max);

            points = points.Where((val, idx) => idx != maxIndex).ToArray();

            int sum = points[0] + points[1] + points[2];
         
            Console.WriteLine("Tolal points are " + sum);
            Console.ReadLine();
        }
    }
}
