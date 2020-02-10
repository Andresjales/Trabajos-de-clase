using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Ingrese su salario: ");
            double salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 1 si su contrato es dependiente o 2 si su contrato es independiente: ");
            int depInd = int.Parse(Console.ReadLine());
            double smmlv = 877803, prima = 0;
            double arl = 0, eps = 0, pension = 0;
            double baseCot = salario * 0.4;

            if (baseCot < smmlv)
            {
                baseCot = smmlv;
            }

            if (depInd == 1)
            {
                eps = 0.04 * baseCot;
                pension = 0.04 * baseCot;
                prima = salario;
            }
            else if (depInd == 2)
            {
                eps = 0.125 * baseCot;
                pension = 0.16 * baseCot;
                Console.WriteLine("Ingrese su tipo de riesgo (1-5): ");
                int riesgo = int.Parse(Console.ReadLine());
                if (riesgo == 1)
                {
                    arl = 0.522 / 100;
                }
                else if (riesgo == 2)
                {
                    arl = 1.044 / 100;
                }
                else if (riesgo == 3)
                {
                    arl = 2.436 / 100;
                }
                else if (riesgo == 4)
                {
                    arl = 4.350 / 100;
                }
                else if (riesgo == 5)
                {
                    arl = 6.960 / 100;
                }
                else
                {
                    Console.WriteLine("No eligio ningun tipo de riesgo.");
                }
            }
            else
            {
                Console.WriteLine("No eligio ningun tipo de contrato.");
            }

            double salarioReal = salario - (eps + pension + (arl * baseCot));
            double salarioAnual = (salarioReal * 12) + prima;

            Console.WriteLine("Su salario real es de: " + salarioReal);
            Console.WriteLine("Su salario anual es de: " + salarioAnual);
        }
    }
}
