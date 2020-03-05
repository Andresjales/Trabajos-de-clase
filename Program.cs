using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la frase: ");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            Console.WriteLine("¿Qué palabra desea buscar?");
            string palabra = Console.ReadLine();
            palabra = palabra.ToUpper();
            int contador = 0;

            for (int i = 0; i < (frase.Length-palabra.Length)+1; i++)
            {
                string palabraFormada = "";
                for (int j = 0; j < palabra.Length; j++)
                {
                    palabraFormada += frase[i + j];
                }

                if (palabraFormada == palabra)
                {
                    Console.WriteLine("Palabra encontrada en la posicion " + (i+1));
                    contador++;
                }
            }

            Console.WriteLine("La palabra se encuentra " + contador + " veces.");
        }
    }
}
