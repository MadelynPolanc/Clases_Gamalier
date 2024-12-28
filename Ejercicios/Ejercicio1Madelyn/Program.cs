using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Madelyn
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Introduce el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Introduce el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Introduce la operación (+, -, *, /): ");
                string operacion = Console.ReadLine();

                if (operacion == "+")
                    Console.WriteLine(num1 + num2);
                else if (operacion == "-")
                    Console.WriteLine(num1 - num2);
                else if (operacion == "*")
                    Console.WriteLine(num1 * num2);
                else if (operacion == "/")
                {
                    if (num2 != 0)
                        Console.WriteLine(num1 / num2);
                    else
                        Console.WriteLine("Error: No se puede dividir entre cero");
                }
                else
                    Console.WriteLine("Operación no válida.");
            }
        }

    }

