using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    public class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        { 

        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
