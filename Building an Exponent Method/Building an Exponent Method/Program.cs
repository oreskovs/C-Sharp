using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetPow(2, 3));


            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;
        }
    }
}