using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, turnos = 0, vidas = 3, unos = 0, seis = 0, especial = 2;
            string continuar = "s", contEsp = "s";

            while (continuar == "s")
            {
                turnos++;
                Console.WriteLine("Turno " + turnos + " Vidas: " + vidas);

                if (especial > 0)
                {
                    Console.WriteLine("Tiene un dado especial. ¿Desea utilizarlo? (s/n): ");
                    contEsp = Console.ReadLine();                    
                }
                else
                {
                    contEsp = "n";
                }

                if (contEsp == "s")
                {
                    dado = aleatorio.Next(1, 13);
                    especial--;
                }
                else
                {
                    dado = aleatorio.Next(1, 7);
                }

                Console.WriteLine("Dado = " + dado);

                total += dado;

                if (dado == 1)
                {
                    unos++;
                }

                if (unos == 2)
                {
                    vidas -= 1;
                    total -= 10;
                    unos = 0;
                    Console.WriteLine("Perdiste una vida. Ahora tu total es = " + total);
                    if (vidas == 0)
                    {
                        Console.WriteLine("Te quedaste sin vidas. Perdiste. Más suerte para la próxima.");
                        break;
                    }
                }

                if (dado == 6)
                {
                    seis++;
                }
                else
                {
                    seis = 0;
                }

                if (seis == 2)
                {
                    vidas++;
                    Console.WriteLine("¡Conseguiste una vida!");
                    if (vidas > 3)
                    {
                        vidas = 3;
                        Console.WriteLine("Ya tienes el maximo de vidas.");
                    }
                }

                if (total >= 100)
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

            Console.WriteLine("Su total fue: " + total + " puntos.");
            Console.WriteLine("Gracias por participar.");
        }
    }
}
