using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    public class Ejercicio3 : IPractica1

    {
        //Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” <nombre> ” y tienes ” <años> ” años”

        public void Ejecutar()
        {
            Console.Write("Ingrese su nombre: ");
            string? nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            string? edad = Console.ReadLine();

            Console.WriteLine($"Te llamas {nombre} y tienen {edad} años");
        }

    }
}
