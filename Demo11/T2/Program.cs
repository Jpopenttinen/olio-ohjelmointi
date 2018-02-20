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
            MailBook Hakemisto = new MailBook();
            List<Friend> Frendit = new List<Friend>();

            Frendit = Hakemisto.GetEmails();

            foreach (Friend a in Frendit)
            {
                Console.WriteLine(a.Name);
            }

            Console.WriteLine("Give a name or it's first letters: ");
            string line = Console.ReadLine();
            //var foo = Frendit.FirstOrDefault(x => x.Name.StartsWith(line));
            var foo = Frendit.FirstOrDefault(x => x.Name.StartsWith(line));
            Console.WriteLine(foo);


        }
    }
}
