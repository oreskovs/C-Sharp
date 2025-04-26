using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
               }
            if (outOfGuesses)
            {
                Console.WriteLine("You loose!");
            }
            else
            {
                Console.WriteLine("You win.\nThe secret word was " + guess );
            }



                Console.ReadLine();
        }
    }
}