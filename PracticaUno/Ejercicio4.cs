using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Ejercicio4 : IPractica1
    {
        /*4) Pedir dos números al usuario por teclado y decir qué número es el mayor.*/
        public void Ejecutar()
        {
            int numero1, numero2;


            Console.WriteLine("Ingrese el primer número:");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Ingrese el segundo número:");
            int.TryParse(Console.ReadLine(), out numero2);

            if (numero1 > numero2)
            {
                Console.WriteLine($"El número {numero1} es mayor que el número {numero2}.");

                Console.WriteLine($"El número {numero1} es mayor que el número {numero2}.");

            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El número {numero2} es mayor que el número {numero1}.");
            }
            else
            {
                Console.WriteLine($"Los números {numero1} y {numero2} son iguales.");
            }
        }
    }
}
