using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynBucles1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Ingresa la cantidad de números que deseas analizar: ");
                int n = int.Parse(Console.ReadLine());

                int positivos = 0, negativos = 0, pares = 0, impares = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Ingresa el número {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero > 0)
                        positivos++;
                    else if (numero < 0)
                        negativos++;

                    if (numero % 2 == 0)
                        pares++;
                    else
                        impares++;
                }

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Cantidad de números positivos: {positivos}");
                Console.WriteLine($"Cantidad de números negativos: {negativos}");
                Console.WriteLine($"Cantidad de números pares: {pares}");
                Console.WriteLine($"Cantidad de números impares: {impares}");
            }
        }

    }

