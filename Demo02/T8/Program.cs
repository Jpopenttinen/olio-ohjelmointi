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
            //Kysytään sana
            string sentence;
            Console.WriteLine("give a word");
            sentence = Console.ReadLine();
            
            // Muutetaan string Charriksi
            string senTrimd = sentence.Replace(" ","");
            char[] senArray = senTrimd.ToCharArray();
            char[] senArrayDesc = senTrimd.ToCharArray();

          
            // Käännetään nurinperin
            Array.Reverse(senArrayDesc);

            bool cmpr = senArray.SequenceEqual(senArrayDesc);
            if (cmpr) Console.WriteLine("It's Palindromi");
            else Console.WriteLine("It isn't Palindromi");

            Console.ReadLine();
           
        }
    }
}
