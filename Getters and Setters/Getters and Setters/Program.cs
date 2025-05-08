using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Getters_and_Setters;

namespace GettersandSetters
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "DOG");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}