// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using CurrencyRatesFetcher;

namespace MyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ExchangeService service = new ExchangeService();

            Console.WriteLine("Enter base currency (e.g., EUR, USD):");
            string currency = Console.ReadLine().ToUpper();

            string result = await service.GetRatesAsync(currency);
            Console.WriteLine(result);
        }
    }
}