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
            double smmlv = 877803;
            double baseCot = (40 * salario) / 100;

            if (depInd == 1)
            {
                if (baseCot < smmlv)
                {
                    double pension = (4 * smmlv) / 100;
                    double eps = (4 * smmlv) / 100;
                    double sReal = salario - pension - eps;
                    double sAnualR = (sReal * 12) + salario;

                    Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                }

                else
                {
                    double pension = (4 * baseCot) / 100;
                    double eps = (4 * baseCot) / 100;
                    double sReal = salario - pension - eps;
                    double sAnualR = (sReal * 12) + salario;

                    Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                }
            }

            else if (depInd == 2)
            {
                Console.WriteLine("Ingrese un numero del 1 al 5 equivalente a la clase de riesgo laboral: ");
                int riesgo = int.Parse(Console.ReadLine());

                if (baseCot < smmlv)
                {
                    if (riesgo == 1)
                    {
                        double pension = (16 * smmlv) / 100;
                        double eps = (12.5 * smmlv) / 100;
                        double arl = (0.522 * smmlv) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 2)
                    {
                        double pension = (16 * smmlv) / 100;
                        double eps = (12.5 * smmlv) / 100;
                        double arl = (1.044 * smmlv) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 3)
                    {
                        double pension = (16 * smmlv) / 100;
                        double eps = (12.5 * smmlv) / 100;
                        double arl = (2.436 * smmlv) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 4)
                    {
                        double pension = (16 * smmlv) / 100;
                        double eps = (12.5 * smmlv) / 100;
                        double arl = (4.350 * smmlv) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 5)
                    {
                        double pension = (16 * smmlv) / 100;
                        double eps = (12.5 * smmlv) / 100;
                        double arl = (6.960 * smmlv) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else
                    {
                        Console.WriteLine("No eligio  ningun tipo de riesgo laboral.");
                    }
                }

                else
                {
                    if (riesgo == 1)
                    {
                        double pension = (16 * baseCot) / 100;
                        double eps = (12.5 * baseCot) / 100;
                        double arl = (0.522 * baseCot) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 2)
                    {
                        double pension = (16 * baseCot) / 100;
                        double eps = (12.5 * baseCot) / 100;
                        double arl = (1.044 * baseCot) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 3)
                    {
                        double pension = (16 * baseCot) / 100;
                        double eps = (12.5 * baseCot) / 100;
                        double arl = (2.436 * baseCot) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 4)
                    {
                        double pension = (16 * baseCot) / 100;
                        double eps = (12.5 * baseCot) / 100;
                        double arl = (4.350 * baseCot) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else if (riesgo == 5)
                    {
                        double pension = (16 * baseCot) / 100;
                        double eps = (12.5 * baseCot) / 100;
                        double arl = (6.960 * baseCot) / 100;
                        double sReal = salario - pension - eps - arl;
                        double sAnualR = (sReal * 12);

                        Console.WriteLine("Su salario real mensual es de: " + sReal + " Su salario anual real es de: " + sAnualR);
                    }

                    else
                    {
                        Console.WriteLine("No eligio ningun tipo de riesgo laboral.");
                    }
                }
            }

            else
            {
                Console.WriteLine("No eligio ningun tipo de contrato.");
            }
        }
    }
}
