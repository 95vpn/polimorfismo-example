using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    public class Caballo : Mamiferos, IMamiferosTerrrestres
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int numeroPatas()
        {
            return 4;
        }
    }
}
