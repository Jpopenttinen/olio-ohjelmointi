using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("give a word");
            sentence = Console.ReadLine();
            //sentence = sentence.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string senTrimd = sentence.Trim();
            char[] senArray = senTrimd.ToCharArray();
            char[] senArrayDesc = senTrimd.ToCharArray();

          

            Array.Reverse(senArrayDesc);

            bool cmpr = senArray.SequenceEqual(senArrayDesc);
            if (cmpr) Console.WriteLine("It's Palindromi");
            else Console.WriteLine("It isn't Palindromi");

            Console.ReadLine();
           
        }
    }
}
