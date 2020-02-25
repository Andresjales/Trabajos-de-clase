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
            double sumatoria = 0, sin = 0;
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                double anterior = sin;
                sumatoria += ((Math.Pow(-1, i)) / Factorial((2 * i) + 1)) * Math.Pow(x, (2 * i) + 1);
                sin = sumatoria;
                Console.WriteLine("\nIteración: " + (i + 1));
                Console.WriteLine("sin(x): " + sin);
                if (sin == anterior) break;
            }
        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
