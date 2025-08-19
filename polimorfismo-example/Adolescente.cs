using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    public class Adolescente : Humano
    {
        public Adolescente(string nombreAdolescente) : base(nombreAdolescente) 
        { 

        }

        public override void pensar()
        {
            Console.WriteLine("las hormonas impiden pensar con claridad");
        }
    }
}
