using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    public class Gorila : Mamiferos, IMamiferosTerrrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        
        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public int numeroPatas()
        {
            return 2;
        }
    }
}
