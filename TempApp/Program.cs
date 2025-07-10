// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.IO;
using System.ComponentModel;


class Program
{

    static int NajniskaTemp(List<int> lista)
    {
        int minTemp = lista[0];

        foreach (int item in lista)
        {
            if (item < minTemp)
            {
                minTemp = item;
            }
        }

        return minTemp;
    }

    static int NajvisokaTemp(List<int> lista)
    {
        int maxTemp = lista[0];

        foreach (int item in lista)
        {
            if (maxTemp < item)
            {
                maxTemp = item;
            }
        }

        return maxTemp;
    }

    static double ProsecnaTemp(List<int> lista)
    {
        int zbir = 0;

        foreach (int item in lista)
        {
            zbir += item;
        }

        double prosek = (double)zbir / lista.Count;

        return prosek;
    }



    static int VkupenTempNegativni(List<int> lista)
    {
        int zbirNaNegativni = 0;

        foreach (int item in lista)
        {
            if (item < 0)
            {
                zbirNaNegativni++;
            }
        }

        return zbirNaNegativni;
    }

    static void Main()
    {
        Console.WriteLine("Kolku temperaturi sakas da vneses");
        int kolTemp = int.Parse(Console.ReadLine());

        List<int> vnesTemp = new List<int>();

        for (int i = 0; i < kolTemp; i++)
        {
            Console.WriteLine($"Vnesi temperatura {i + 1}");
            int broj = int.Parse(Console.ReadLine());
            vnesTemp.Add(broj);
        }


        Console.WriteLine("Vnesenite temperaturi se:");
        foreach (int temp in vnesTemp)
        {
            Console.WriteLine(temp);
        }

        int negTemp = VkupenTempNegativni(vnesTemp);
        double avgTemp = ProsecnaTemp(vnesTemp);
        int maxTemp = NajvisokaTemp(vnesTemp);
        int minTemp = NajniskaTemp(vnesTemp);

        Console.WriteLine($"Vkupno ima {negTemp} pod 0(negativni)");
        Console.WriteLine($"Prosecnata temperatura e: {avgTemp}");
        Console.WriteLine($"Maksimalnata temperatura e: {maxTemp}");
        Console.WriteLine($"Najniskata temperatura e: {minTemp}");

    }
}
