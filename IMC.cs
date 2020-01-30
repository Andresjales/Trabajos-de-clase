using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese su peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estatura (m): ");
            double estatura = double.Parse(Console.ReadLine());
            //Calculo de IMC
            double imc = peso / Math.Pow(estatura, 2);
            //Salida de resultados
            if (imc <= 18.4)
            {
                Console.WriteLine("IMC: " + imc + " Usted está bajo de peso.");
            }
            else if (18.5 <= imc && imc < 25)
            {
                Console.WriteLine("IMC: " + imc + " Usted tiene un peso normal.");
            }
            else if (25 <= imc && imc <= 29.9)
            {
                Console.WriteLine("IMC: " + imc + " Usted tiene sobrepeso.");
            }
            else
            {
                Console.WriteLine("IMC: " + imc + " Usted tiene obesidad.");
            }
        }
    }
}
