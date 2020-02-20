using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 11);
            int b = rnd.Next(1, 11);
            int sumaCorrecta = a + b;
            int suma = 0;
            int intentos = 3;

            Console.WriteLine("Si usted es humano ingrese la suma entre " + a + " y " + b);
            suma = int.Parse(Console.ReadLine());

            while (sumaCorrecta != suma && intentos > 1)
            {
                intentos--;
                Console.WriteLine("Incorrecto");
                a = rnd.Next(1, 11);
                b = rnd.Next(1, 11);
                sumaCorrecta = a + b;
                Console.WriteLine("\nSi usted es humano ingrese la suma entre " + a + " y " + b);
                suma = int.Parse(Console.ReadLine());
            }

            if (suma == sumaCorrecta)
            {
                Console.WriteLine("Usted tiene permiso de continuar.");
            }
            else
            {
                Console.WriteLine("Acceso denegado.");
            }
        }
    }
}
