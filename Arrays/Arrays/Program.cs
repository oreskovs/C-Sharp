using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 24, 42 };
            string[] friends = new string[7];



            friends[0] ="Jim";
            friends[1] = "John";

            Console.WriteLine(friends[1]);


            luckyNumbers[1] = 7;

            Console.WriteLine( luckyNumbers[1] );


            Console.ReadLine();
        } 
    }
}