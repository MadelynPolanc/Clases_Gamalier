using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio11
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

                Console.WriteLine($"\nEl promedio de las notas es: {promedio}");

                if (promedio >= 90)
                {
                    Console.WriteLine("Calificación: Excelente");
                }
                else if (promedio >= 80)
                {
                    Console.WriteLine("Calificación: Muy bueno");
                }
                else if (promedio >= 75)
                {
                    Console.WriteLine("Calificación: Bueno");
                }
                else if (promedio >= 70)
                {
                    Console.WriteLine("Calificación: Regular");
                }
                else
                {
                    Console.WriteLine("Calificación: Deficiente");
                }
        }
    }

}

