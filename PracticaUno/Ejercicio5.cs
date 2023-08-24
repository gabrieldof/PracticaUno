using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Ejercicio5 : IPractica1
    {
        /*5) Pedir el nombre del día al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo. 
         * Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” / “  lunes” y debería funcionar. 
         * TIP para investigar: Trim() y StringComparison.OrdinalIgnoreCase
         */
        public void Ejecutar()
        {

            Console.WriteLine("Ingrese el nombre de un día:");
            string dia = Console.ReadLine().Trim().ToLower();

            bool esFinDeSemana = false;

            if (dia.Equals("sábado", StringComparison.OrdinalIgnoreCase) || dia.Equals("domingo", StringComparison.OrdinalIgnoreCase))
            {
                esFinDeSemana = true;
            }

            if (esFinDeSemana)
            {
                Console.WriteLine($"El día {dia} es fin de semana.");
            }
            else if (dia.Equals("lunes", StringComparison.OrdinalIgnoreCase) || dia.Equals("martes", StringComparison.OrdinalIgnoreCase) || dia.Equals("miércoles", StringComparison.OrdinalIgnoreCase) || dia.Equals("jueves", StringComparison.OrdinalIgnoreCase) || dia.Equals("viernes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"El día {dia} es laboral.");
            }
            else
            {
                Console.WriteLine($"El día {dia} es inválido.");
            }



        }
    }
}
