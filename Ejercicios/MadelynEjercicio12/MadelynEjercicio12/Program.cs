using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa un número entero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
        }
    }

}

