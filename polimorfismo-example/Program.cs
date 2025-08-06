using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miBabieca = new Caballo("Babieca");
            Humano miJuan = new Humano("Juan");
            Gorila miCopito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;
            almacenAnimales[1] = miJuan;
            almacenAnimales[2] = miCopito;

            //almacenAnimales[1].getNombre();

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }
        }
    }
}
