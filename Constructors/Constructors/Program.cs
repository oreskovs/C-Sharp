using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
     
            Book book2 = new Book("Lord of The Rings", "Tolkein", 700);

            book2.title = "The hobbit";


            Console.WriteLine(book2.title);


            Console.ReadLine();
        }
    }
}