using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("I'm thinking of a number between 0 and 100.");
            Random rnd = new Random();
            int number = rnd.Next(101);

            Console.WriteLine("Try to guess what number I am thinking of: ");
            string guessString = Console.ReadLine();
            int guess = Int32.Parse(guessString);
            int tries = 1;

            while(guess != number)
            {
                if(guess > number)
                {
                    tries++;
                    Console.WriteLine("Your guess is too high! Try again:");
                    guessString = Console.ReadLine();
                    guess = Int32.Parse(guessString);
                }
                else
                {
                    tries++;
                    Console.WriteLine("Your guess is too low! Try again:");
                    guessString = Console.ReadLine();
                    guess = Int32.Parse(guessString);
                }
            }

            Console.WriteLine("Nice guess! It took you " + tries + " tries to guess the correct value!");
            Console.WriteLine("Press Enter to close the window.");
            Console.ReadLine();
        }
    }
}
