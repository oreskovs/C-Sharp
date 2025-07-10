using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presmetuvanje_Plostina_Perimetar
{
    internal class Kvadrat : Oblik
    {
        private double strana;

        public Kvadrat(double kStrana) 
        {
            strana = kStrana;
        }

        public override double PresmetajPlostina()
        {
            double plostina = strana * strana;

            return plostina;
        }

        public override double PresmetajPerimetar()
        {

            double perimetar = 4 * strana;
            return perimetar;


        }

        public override void PecatiInfo()
        {
            Console.WriteLine($"Kvadrat so strana {strana}, plostina {PresmetajPlostina()}, i perimetar {PresmetajPerimetar()}");
        }

    }
}
