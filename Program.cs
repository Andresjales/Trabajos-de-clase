using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string maxName = "", minName = "";

            while (i < n)
            {
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maxName = nombre;
                    max = edad;
                    minName = nombre;
                    min = edad;
                }
                
                if (edad > max)
                {
                    maxName = nombre;
                    max = edad;
                }
                if (edad < min)
                {
                    minName = nombre;
                    min = edad;
                }

                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("El mayor es: " + maxName + " con " + max + " años.");
            Console.WriteLine("El menor es: " + minName + " con " + min + " años.");
        }
    }
}
