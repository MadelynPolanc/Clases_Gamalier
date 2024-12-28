using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynBucles8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero;

            do
            {
                Console.Write("Ingresa un número (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
            } while (numero != 0);

            Console.WriteLine("La sumatoria de los números ingresados es: " + suma);

        }
    }
}
