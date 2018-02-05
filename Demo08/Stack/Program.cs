using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            // STACK

            /*

            // create stack for strings
            Stack<string> stackStrings = new Stack<string>();
            // add strings
            stackStrings.Push("first");
            stackStrings.Push("second");
            stackStrings.Push("third");

            // get first
            Console.WriteLine(stackStrings.Peek()); // third

            // print all
            foreach (string s in stackStrings)
            {
                Console.WriteLine(s);
            }
            // outputs
            //  third
            //  second
            //  first

            // get and delete first
            string temp = stackStrings.Pop();
            Console.WriteLine("temp is {0}", temp); // temp is third
            Console.WriteLine("Count is {0}", stackStrings.Count); // count is 2

            Console.WriteLine(stackStrings.Peek());

            Console.ReadLine();

    */


            //  QUEUE

            // create queue instance
            Queue<string> queue = new Queue<string>();
            // add values
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            // get first and leave it to collection
            string first = queue.Peek();
            Console.WriteLine("first in queue is {0}", first); // first
            Console.WriteLine("Count is {0}", queue.Count); // 3
                                                            // get first and remove it from collecion
            first = queue.Dequeue();
            Console.WriteLine("first in queue is {0}", first);  // first
            Console.WriteLine("Count is {0}", queue.Count); // 2

            Console.ReadLine();
        }

    
    }
}
