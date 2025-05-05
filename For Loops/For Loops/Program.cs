using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 5, 7, 18, 24, 28, 33, 77 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }


            Console.ReadLine();
        }
    }
}