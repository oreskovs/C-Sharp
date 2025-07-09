// See https://aka.ms/new-console-template for more information

using System;

class Program
{

    static int NajgolemBroj(int[] niza)
    {
        int max = niza[0];

        foreach (int broj in niza)
        {
            if (max < broj)
            {
                max = broj;
            }
        }

        return max;

    }

    static int[] PrikaziNiza(int[] niza)
    {

        Array.Sort(niza);

        Console.WriteLine("Vnesenite broevi se:");

        foreach (int broj in niza)
        {
            Console.WriteLine(broj);
        }


        return niza;
    }

    static int[] VnesiBroevi()
    {

        Console.WriteLine("Kolku broevi sakas da vnesis?");
        int nizaDolzina = int.Parse(Console.ReadLine());

        int[] niza = new int[nizaDolzina];


        for (int broj = 0; broj < nizaDolzina; broj++)
        {
            int vrednost = 0;

            do
            {
                Console.WriteLine($"Dodadi broj {broj + 1}");
                vrednost = int.Parse(Console.ReadLine());

                if (vrednost < 0)
                {
                    Console.WriteLine("Vneseniot broj mora da e pogolem ili ednakov na 0!");
                }


            } while (vrednost < 0);
            niza[broj] = vrednost;
        }


        return niza;
    }

    static double PresmetajProsek(int[] niza)
    {

        int nizazbir = PresmetajZbir(niza);

        double prosek = (double)nizazbir / niza.Length;

        return prosek;
    }

    static int PresmetajZbir(int[] niza)
    {
        int zbir = 0;

        foreach (int broj in niza)
        {

            zbir += broj;

        }

        return zbir;

    }


    static void Main()
    {
        int[] arr = null;

        while (true)
        {
            Console.WriteLine("\n--- Meni ---");
            Console.WriteLine("1. Vnesi broevi");
            Console.WriteLine("2. Prikazi broevi (sortirani)");
            Console.WriteLine("3. Zbir");
            Console.WriteLine("4. Prosek");
            Console.WriteLine("5. Najgolem broj");
            Console.WriteLine("0. Izlez");
            Console.Write("Izberi opcija: ");
            string izbor = Console.ReadLine();

            switch (izbor)
            {
                case "1":
                    arr = VnesiBroevi();
                    break;

                case "2":
                    if (arr != null)
                        PrikaziNiza(arr);
                    else
                        Console.WriteLine("⚠️ Prvo vnesi broevi!");
                    break;

                case "3":
                    if (arr != null)
                        Console.WriteLine($"Zbir: {PresmetajZbir(arr)}");
                    else
                        Console.WriteLine("⚠️ Prvo vnesi broevi!");
                    break;

                case "4":
                    if (arr != null)
                        Console.WriteLine($"Prosek: {PresmetajProsek(arr):F2}");
                    else
                        Console.WriteLine("⚠️ Prvo vnesi broevi!");
                    break;

                case "5":
                    if (arr != null)
                        Console.WriteLine($"Najgolem broj: {NajgolemBroj(arr)}");
                    else
                        Console.WriteLine("⚠️ Prvo vnesi broevi!");
                    break;

                case "0":
                    Console.WriteLine("👋 Programata zavrshi. Pozdrav!");
                    return;

                default:
                    Console.WriteLine("❌ Nevalidna opcija. Obidi se povtorno.");
                    break;
            }
        }
    }
}
