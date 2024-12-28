using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynBucles3
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Ingresa la cantidad de números que deseas sumar: ");
                int n = int.Parse(Console.ReadLine());
                int suma = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Ingresa el número {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());
                    suma += numero;

                    if (suma >= 100)
                    {
                        Console.WriteLine("\nLa sumatoria es mayor o igual a 100.");
                        break;
                    }
                }

                if (suma < 100)
                {
                    Console.WriteLine($"\nLa sumatoria total es: {suma}");
                }
            }
        }

    }

