using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest test = new ClassTest("opel", "green");
            test.Model = "toyota";
            test.Color = "brown";
            Console.WriteLine(test.Model);




            Console.ReadLine();
        }
    }
}
