using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Ejercicio8 : IPractica1
    {
        /*8) Recorrer los números del 1 al 100. Usar un bucle while.*/
        public void Ejecutar()
        {
            int i = 1;

            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}
