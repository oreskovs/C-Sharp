using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age + " years old!");


            Console.ReadLine();
        }
    }
}