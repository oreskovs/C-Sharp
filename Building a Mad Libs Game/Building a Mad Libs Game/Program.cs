﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MadLibsGame { 

    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color + "!");
            Console.WriteLine(pluralNoun + " are blue!");
            Console.WriteLine("I love " + celebrity + "!");



            Console.ReadLine();
        }
    }
    
}
