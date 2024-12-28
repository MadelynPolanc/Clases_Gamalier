using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Madelyn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double suma = num1 + num2 + num3;
            double resta = num1 - num2 - num3;
            double multiplicacion = num1 * num2 * num3;
            double division = num1 / num2 / num3;

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Suma: {num1} + {num2} + {num3} = {suma}");
            Console.WriteLine($"Resta: {num1} - {num2} - {num3} = {resta}");
            Console.WriteLine($"Multiplicación: {num1} * {num2} * {num3} = {multiplicacion}");
            Console.WriteLine($"División: {num1} / {num2} / {num3} = {division}");
        }
    }
}
