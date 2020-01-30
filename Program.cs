using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());
            //Calculos
            
            double discriminante = Math.Pow(b, 2) - 4 * a * c;
            //Salida
            if (discriminante == 0)
            {
                double x1 = (-b) / (2 * a);
                Console.WriteLine("La solución existe y es unica: " + " x = " + x1);
            }
            else if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Existen dos posibles soluciones: " + " x1 = " + x1 + " x2 = " + x2);
            }
            else
            {
                Console.WriteLine("No es posible calcular la solución.");
            }
        }
    }
}
