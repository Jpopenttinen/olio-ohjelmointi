using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1
{
    class Program
    {
        public delegate string StringHandler(string line);

        static void Main(string[] args)
        {

            Console.WriteLine("Give a word");
            string line = Console.ReadLine();
            string help;
            int operInt = 0;
            Moderator mod = new Moderator();
            StringHandler handler = new StringHandler(mod.Upperer);
            string result;
            while (true)
            {
                Console.WriteLine("Give an operation, you can give multiple operations at once (eg. '123'):");
                Console.WriteLine("1. Change word to Upper case");
                Console.WriteLine("2. Change word to Lower case");
                Console.WriteLine("3. Change word to Headline");
                Console.WriteLine("4. Change word to Palidrome");
                Console.WriteLine("0. exit the program");
                help = Console.ReadLine();
                char[] oper = help.ToCharArray();

                for (int i = 0; i < oper.Length; i++)
                {
                    operInt = int.Parse(oper[i].ToString());

                    switch (operInt)
                    {
                        case 1:
                            result = handler(line);
                            Console.WriteLine("{0} is changed to {1}", line, result);
                            break;
                        case 2:
                            handler = new StringHandler(mod.Lowerer);
                            result = handler(line);
                            Console.WriteLine("{0} is changed to {1}", line, result);
                            break;
                        case 3:
                            handler = new StringHandler(mod.Capitalize);
                            result = handler(line);
                            Console.WriteLine("{0} is changed to {1}", line, result);
                            break;
                        case 4:
                            handler = new StringHandler(mod.Palindrome);
                            result = handler(line);
                            Console.WriteLine("{0} is changed to {1}", line, result);
                            break;
                        case 0:
                            break;
                    }
                    
                }
                if (operInt == 0) { break; }
            }

        }
    }

    public class Moderator
    {
        public string Upperer(string line)
        {
            return line.ToUpper();
        }
        public string Lowerer(string line)
        {
            return line.ToLower();
        }
        public string Capitalize(string line)
        {
            return line.First().ToString().ToUpper() + line.Substring(1);
        }
        public string Palindrome(string line)
        {
            char[] cArray = line.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }



    }
}
