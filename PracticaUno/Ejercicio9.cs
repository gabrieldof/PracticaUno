using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Ejercicio9 : IPractica1
    {
        /*9) Recorrer los números del 1 al 100. Mostrar los números pares. Usar el tipo de bucle que quieras.*/
        public void Ejecutar()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
