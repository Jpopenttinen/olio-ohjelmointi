using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 100);
            Console.WriteLine(rndNumber);

            string guessed;
            int guessdNumber;
            int guessCount = 0;

            while (true)
            {
                Console.WriteLine("Guess a number: ");
                guessed = Console.ReadLine();
                Int32.TryParse(guessed, out guessdNumber);
                guessCount++;
                if (guessdNumber > rndNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guessdNumber < rndNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("You got me! It took " + guessCount + " guesses");
                    break;
                }
  
            }
            Console.ReadLine();
        }
    }
}
