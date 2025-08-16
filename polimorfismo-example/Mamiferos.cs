using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    public class Mamiferos : Animales 
    {
        private String nombreSerVivo;
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        

        public virtual void pensar()
        {
            Console.WriteLine("pensamiento basico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan ");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamifero es: " + nombreSerVivo);
        }


        public int numeroPatas()
        {
            return numeroPatas();
        }

    }
}
