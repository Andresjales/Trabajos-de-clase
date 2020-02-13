using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dado1 = 0, dado2 = 0, total = 0;
            string continuar = "s";
            int turnos = 0;
            int turnos2 = 0;
            int dobles = 0;

            while (continuar == "s")
            {
                turnos++;
                Console.WriteLine("Turno " + turnos);
                dado1 = rnd.Next(1, 7);
                dado1 = rnd.Next(1, 7);
                dado2 = rnd.Next(1, 7);
                Console.WriteLine("Dado 1 = " + dado1 + " Dado 2 = " + dado2);

                if (dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("Eliminado.");
                    continuar = "n";
                }
                else
                {
                    total += dado1 + dado2;

                    if (dado1 == dado2)
                    {
                        dobles++;
                    }
                    else
                    {
                        dobles = 0;
                    }

                    if ((dado1 + dado2) >= 6)
                    {
                        turnos2++;
                    }

                    if (total >= 100 || dobles == 3)
                    {
                        Console.WriteLine("Ganaste!");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("¿Deasea continuar? (s/n): ");
                        continuar = Console.ReadLine();
                    }
                }
            }

            double porcentaje = (turnos2 * 100) / turnos;
            Console.WriteLine("Tu total fue de " + total + " puntos.");
            Console.WriteLine("El porcentaje de veces en las que sacó 6 o más es de: " + porcentaje + "%");
            Console.WriteLine("Gracias por participar.");
        }
    }
}
