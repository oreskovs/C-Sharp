using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class Kosnica
    {
        List<Product> Produkti = new List<Product>();

        public Kosnica(List<Product> кProdukti)
        {
            Produkti = кProdukti;
        }

        public void AddToCart(Product product)
        {

            bool najden = false;

            foreach (Product p in Produkti)
            {
                if (p.Ime.ToLower() == product.Ime.ToLower())
                {
                    p.Kolicina += product.Kolicina;
                    najden = true;
                    break;

                }
            }

            if (!najden)
            {
                Produkti.Add(product);

            }


        }

        public decimal PresmetajVkupno()
        {
            decimal total = 0;

            foreach (Product product in Produkti)
            {
                total += product.Cena * product.Kolicina;
            }

            return total;
        }

        public void PecatiProdukti()
        {
            if (Produkti.Any())
            {
                foreach (Product p in Produkti)
                {
                    p.PrintInfo();
                }
            }
            else
            {
                Console.WriteLine($"Vasata kosnica e prazna");
            }


        }

        public void IzbrisiProdukt(string imeNaProdukt)
        {
            bool najden = false;

            for (int i = 0; i < Produkti.Count; i++)
            {
                if (Produkti[i].Ime.ToLower() == imeNaProdukt.ToLower())
                {
                    Produkti.RemoveAt(i);
                    Console.WriteLine($"Produktot {imeNaProdukt} e uspesno izbrisan od kosnicata!");
                    najden = true;
                    break;
                }


            }
            if (!najden)
            {
                Console.WriteLine($"Produktot so ime {imeNaProdukt} ne e pronajden vo kosnicata.");
            }
        }

        public void AzurirajKolicina(string imeNaProizvod, int novaKolicina)
        {
            bool najden = false;

            if (novaKolicina > 0)
            {
                foreach (Product p in Produkti)
                {
                    if (p.Ime.ToLower() == imeNaProizvod.ToLower())
                    {
                        p.Kolicina = novaKolicina;
                        najden = true;
                    }

                }
                if (!najden)
                {
                    Console.WriteLine($"Produktot so ime {imeNaProizvod} ne e pronajden");
                }
            }
            else
            {
                Console.WriteLine("Vnesete kolicina pogolema od 0");
                return;
            }
        }

        public void PronajdiProdukt(string imeNaProdukt)
        {
            bool najden = false;

            foreach (Product p in Produkti)
            {
                if (p.Ime.ToLower() == imeNaProdukt.ToLower())
                {
                    Console.WriteLine($"Produktot so ime {imeNaProdukt} e najden vo kosnica");
                    Console.WriteLine($"Ime na produktot: {p.Ime} Cena: {p.Cena}$ Kolicina: {p.Kolicina}");
                    najden = true;
                }
            }

            if (!najden)
            {
                Console.WriteLine($"Produktot so ime {imeNaProdukt} ne e najden vo kosnicata");
            }
        }

        public void IsprazniKosnica()
        {
            Produkti.Clear();
            Console.WriteLine("Kosnicata e isprazneta");
        }

        public void PrebarajPoIme(string delOdIme)
        {
            bool najden = false;

            foreach (Product p in Produkti)
            {
                if (p.Ime.ToLower().Contains(delOdIme.ToLower()))
                {
                    najden = true;
                    Console.WriteLine($"Produkt so toa ime");
                    p.PrintInfo();
                }
            }

            if (!najden)
            {
                Console.WriteLine($"Ne postoi produkt koj sodrzi {delOdIme} vo nego.");
            }
        }

        public void SortirajProizvodi(string kriterium)
        {

            if (kriterium.ToLower() == "ime")
            {
                Produkti = Produkti.OrderBy(p => p.Ime).ToList();
                Console.WriteLine("Produkti sortirani po ime (azbucno):");
            }
            else if (kriterium.ToLower() == "cena")
            {
                Produkti = Produkti.OrderByDescending(p => p.Cena).ToList();
                Console.WriteLine("Produkti sortirani po cena (od najskapa kon naevtina):");
            }
            else
            {
                Console.WriteLine("Nevaliden kriterium. Ve molime vnesete 'ime' ili 'cena'.");
                return;
            }

            PecatiProdukti();
        }
    }
}
