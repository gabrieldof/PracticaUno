using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Ejercicio10 : IPractica1
    {
        /*10) Recorrer los números del 1 al 100. Crear 2 listas, una con los números pares y otra con los divisibles entre 3. Mostrar las 2 listas.*/
        public void Ejecutar()
        {
            List<int> pares = new List<int>();
            List<int> divisiblesPor3 = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pares.Add(i);
                }

                if (i % 3 == 0)
                {
                    divisiblesPor3.Add(i);
                }
            }

            Console.WriteLine("Números pares:");
            foreach (int num in pares)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nNúmeros divisibles por 3:");
            foreach (int num in divisiblesPor3)
            {
                Console.Write(num + " ");
            }



        }
    }
}