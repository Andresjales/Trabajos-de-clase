using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de votos por el partido 1: ");
            int votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos por el partido 2: ");
            int votos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos en blanco: ");
            int votosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos anulados: ");
            int votosA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número habitantes: ");
            int habitantes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje (0-100%) de habitantes que son mayores de edad: ");
            double pMayores = double.Parse(Console.ReadLine());

            double mayores = habitantes * (pMayores / 100);
            double abstencion = mayores - (votos1 + votos2 + votosA + votosB);

            bool A = votosA < (30 * (votos1 + votos2) / 100);
            bool B = (votos1 + votos2) > votosB;
            bool C = abstencion < (votos1 + votos2 + votosA + votosB);

            if ((A || B) && C)
            {
                Console.WriteLine("Las elecciones fueron exitosas.");
                if (votos1 > votos2)
                {
                    Console.WriteLine("El ganador fue el partido 1.");
                }
                else
                {
                    Console.WriteLine("El ganador fue el partido 2.");
                }
            }
            else
            {
                Console.WriteLine("Las elecciones deben realizarse nuevamente.");
            }
        }
    }
}
