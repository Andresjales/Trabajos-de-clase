using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de datos: ");
            int n = int.Parse(Console.ReadLine()), posicionMayor = 0, posicionMenor = 0;
            double mayor = 0, menor = 200;
            string[] nombres = new string[n];
            double[] edades = new double[n];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("\nNombre: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Edad: ");
                edades[i] = double.Parse(Console.ReadLine());
                if (edades[i] < menor)
                {
                    menor = edades[i];
                    posicionMenor = i;
                }
                if (edades[i] > mayor)
                {
                    mayor = edades[i];
                    posicionMayor = i;
                }
            }

            double total = 0;
            for (int i = 0; i < edades.Length; i++)
            {
                total += edades[i];
            }

            double promedio = total / n;

            double desv = 0;
            for (int i = 0; i < edades.Length; i++)
            {
                desv += Math.Pow(edades[i] - promedio, 2);
            }

            double desviacion = Math.Sqrt(desv / n);

            double[] cercana = new double[n];
            double masCerc = 200;
            string nombCerc = "";

            for (int i = 0; i < edades.Length; i++)
            {
                cercana[i] = Math.Pow(edades[i] - promedio, 2);
                if (cercana[i] < masCerc)
                {
                    masCerc = cercana[i];
                    nombCerc = nombres[i];
                }
            }

            Console.WriteLine("\nEl mayor es " + (nombres[posicionMayor]) + " con " + mayor);
            Console.WriteLine("\nEl menor es " + (nombres[posicionMenor]) + " con " + menor);
            Console.WriteLine("\nEl promedio de las edades es = " + promedio);
            Console.WriteLine("La desviación de las edades es = " + desviacion);
            Console.WriteLine("La edad más cercana al promedio es = " + nombCerc);
        }
    }
}
