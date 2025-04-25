using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TwoDArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numberGrid = {
                {1,2 },
                {3,4 },
                {5,6 }
            };

            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[1,1]);


            Console.ReadLine();
        }
    }
}