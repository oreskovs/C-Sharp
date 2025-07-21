using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ProductsSortingApp;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                if (!File.Exists("products.json"))
                {
                    Console.WriteLine("File doesn't exist.");
                    return;

                }

                string jsonText = File.ReadAllText("products.json");

                List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonText);

                if (products == null)
                {
                    Console.WriteLine("Invalid or empty JSON data.");
                    return;
                }

                var groupedProducts = products.GroupBy(p => p.IsPerishable);

                foreach (var group in groupedProducts)
                {
                    string groupName = group.Key ? "Perishable Items" : "Non-Perishable Items";
                    Console.WriteLine(groupName);

                    foreach (var product in group)
                    {
                        string displayName = product.Name.Length > 10 ? product.Name.Substring(0, 9) + "..." : product.Name;
                        Console.WriteLine($"Name: {displayName} \nPrice: ${product.Price} \nQuantity: {product.Quantity}");
                    }

                    decimal groupTotal = group.Sum(p => p.Price * p.Quantity);
                    Console.WriteLine($"Total {groupName} Value: ${groupTotal.ToString("0.00")}");

                    int totalQuantity = group.Sum(p => p.Quantity);
                    Console.WriteLine($"Total {groupName} Quantity: {totalQuantity} items");

                    Console.WriteLine("=============================");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Data entry error: {ex.Message}");

            }
            catch (Exception error)
            {
                Console.WriteLine($"Unexpected error {error.Message}");
            }
        }
    }
}