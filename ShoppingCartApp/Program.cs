// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;
using ShoppingCartApp;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> produkti = new List<Product> { new Product("Jabolka", 100, 50), new Product("Banana", 80, 30), new Product("Mandarina", 120, 30) };

            Kosnica kosnica = new Kosnica(produkti);


            while (true)
            {
                Console.WriteLine("=== MENI ===");
                Console.WriteLine("1. Prikazi produkti");
                Console.WriteLine("2. Dodadi produkt");
                Console.WriteLine("3. Izbrishi produkt");
                Console.WriteLine("4. Azuriraj kolicina");
                Console.WriteLine("5. Prebaraj produkt");
                Console.WriteLine("6. Isprazni kosnica");
                Console.WriteLine("7. Presmetaj vkupno");
                Console.WriteLine("8. Izlez");
                Console.Write("Vnesi izbor: ");

                string izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        kosnica.PecatiProdukti();
                        Console.WriteLine("Pritisnete bilo koe dugme za da prodolzite");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Vnesete ime na produkt");
                        string ime = Console.ReadLine();
                        Console.WriteLine("Vnesete cena za produktot");
                        decimal cena = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Vnesete kolicina za produktot");
                        int kolicina = int.Parse(Console.ReadLine());
                        Product novProdukt = new Product(ime, cena, kolicina);
                        kosnica.AddToCart(novProdukt);
                        Console.WriteLine("Pritisnete bilo koe dugme za da prodolzite");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Vnesete ime na produktot");
                        string imeBrisenje = (Console.ReadLine());
                        kosnica.IzbrisiProdukt(imeBrisenje);
                        Console.WriteLine("Pritisnete bilo koe dugme za da prodolzite");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Vnesete ime na proizvodot");
                        string imeAzur = Console.ReadLine();
                        Console.WriteLine("Vnesete nova kolicina");
                        int novaKolicina = int.Parse(Console.ReadLine());
                        kosnica.AzurirajKolicina(imeAzur, novaKolicina);
                        Console.WriteLine("Pritisnete bilo koe dugme za da prodolzite");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("Vnesete ime na proizvodot");
                        string imePreb = Console.ReadLine();
                        kosnica.PronajdiProdukt(imePreb);
                        Console.WriteLine("Pritisnete bilo koe dugme za da prodolzite");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        kosnica.IsprazniKosnica();
                        Console.WriteLine("Pritisnete bilo koe dugme za da prodolzite");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        Console.WriteLine($"Vkupno za naplata: {kosnica.PresmetajVkupno():F2} denari.");
                        Console.WriteLine("Pritisnete bilo koe dugme za da prodolzite");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8":
                        Console.WriteLine("Programata zavrsi.Dogledanje");
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Vnesovte ne validen izbor.");
                        Console.WriteLine("Pritisni bilo koe kopce za prodolzuvanje");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }


            }






        }

    }
}