// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.IO;
using System.ComponentModel;
using Presmetuvanje_Plostina_Perimetar;


class Program
{
    static void Main()
    {
        List<Oblik> oblici = new List<Oblik> { new Krug(5), new Kvadrat(4) };


        foreach(Oblik oblik in oblici)
        {
            oblik.PecatiInfo();
        }

    }
}
