using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Ejercicio7 : IPractica1
    {
        /* 7) Recorrer los números del 1 al 100. Usar un bucle for.*/
        public void Ejecutar()
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
