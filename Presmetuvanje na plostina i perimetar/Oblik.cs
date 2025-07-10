using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ChatGPT_Course
{
    abstract class Oblik
    {
        public abstract double PresmetajPlostina();
        public abstract double PresmetajPerimetar();
        
        public virtual void PecatiInfo()
        {
            Console.WriteLine("Ova e geografski oblik");
        }

    }
}
