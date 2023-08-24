using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    public class Ejercicio2 : IPractica1
    {
        /*2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) 
         * y mostrar por consola el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>”. Utilizar Interpolación.*/
        public void Ejecutar()
        {

            Console.WriteLine("Ingrese el nombre de la persona: ");
            string? personaNombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la ciudad: ");
            string? ciudadNombre = Console.ReadLine();

            Console.WriteLine("Hola " + personaNombre + " bienvenido a " + ciudadNombre);

            string mensaje = $"Hola {personaNombre} bienvenido a {ciudadNombre}";

            Console.WriteLine(mensaje);


        }
    }
}
