using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presmetuvanje_Plostina_Perimetar
{
    internal class Krug : Oblik
    {
        private double radius;

        public Krug(double kradius)
        {
            radius = kradius;
        }

        public override double PresmetajPerimetar()
        {
            double perimetar = 2 * Math.PI * radius;

            return perimetar;
        }

        public override double PresmetajPlostina()
        {
            double plostina = Math.PI * Math.Pow(radius, 2);

            return plostina;
        }


        public override void PecatiInfo()
        {
            Console.WriteLine($"Krug so radius {radius}, plostina {PresmetajPlostina():F2} i perimetar {PresmetajPerimetar():F2}");
        }
    }
}
