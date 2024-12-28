using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa el primer número entero: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el segundo número entero: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el tercer número entero: ");
                int numero3 = Convert.ToInt32(Console.ReadLine());

                if (numero1 >= numero2 && numero1 >= numero3)
                {
                    Console.WriteLine($"El número mayor es: {numero1}");
                }
                else if (numero2 >= numero1 && numero2 >= numero3)
                {
                    Console.WriteLine($"El número mayor es: {numero2}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {numero3}");
                }
        }
    }

}

