using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa la primera nota: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la segunda nota: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la tercera nota: ");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la cuarta nota: ");
                double nota4 = Convert.ToDouble(Console.ReadLine());

                double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine($"\nEl promedio de las notas es: {promedio:F2}");

                if (promedio >= 70)
                {
                    Console.WriteLine("Aprobo.");
                }
                else
                {
                    Console.WriteLine("reprobo.");
                }
        }
    }

}

