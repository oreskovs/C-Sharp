using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class Product
    {
        private string _ime;
        private decimal _cena;
        private int _kolicina;

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public decimal Cena
        {
            get { return _cena; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Cenata ne moze da bide 0 ili pomala od 0");
                }
                else
                {
                    _cena = value;
                }
            }

        }

        public int Kolicina
        {
            get { return _kolicina; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Stavete kolicina pogolema od 0");
                }
                else
                {
                    _kolicina = value;
                }
            }
        }

        public Product(string kIme, decimal kCena, int kKolicina)
        {
            Ime = kIme;
            Cena = kCena;
            Kolicina = kKolicina;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Ime na proizvod: {Ime}");
            Console.WriteLine($"Cena: {Cena}$");
            Console.WriteLine($"Kolicina: {Kolicina}");
        }
    }
}
