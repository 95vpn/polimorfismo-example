using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    public class Caballo : Mamiferos, IMamiferosTerrrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferosTerrrestres.numeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
        public string tipoDeportes()
        {
            return "Hipica";
        }

        public Boolean esOlimpico()
        {
            return true;
        }


    }
}
