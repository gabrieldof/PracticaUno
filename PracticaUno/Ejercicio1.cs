using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    public class Ejercicio1 : IPractica1
    {
        /*1) Crear 3 variables numéricas con el valor que quieras y en otra variable numérica 
         * guardar el valor de la suma de las 3 anteriores. Mostrar por consola.*/
        public void Ejecutar()
        {
            int num1 = 10, num2 = 20, num3 = 30, resultado;

            resultado = num1 + num2 + num3;

            Console.WriteLine(resultado);

        }

    }
}
