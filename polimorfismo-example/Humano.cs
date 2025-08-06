using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    public class Humano : Mamiferos
    {
        public  Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Soy capaz de penzar");
        }
    }
}
