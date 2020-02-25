using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de x: ");
            double x = double.Parse(Console.ReadLine());
            double sumatoria = 0, e = 0;
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                sumatoria += (Math.Pow(x, i)) / Factorial(i);
                e = sumatoria;
                Console.WriteLine("\nIteración: " + (i+1));
                Console.WriteLine("e^x: " + e);
            }
        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
