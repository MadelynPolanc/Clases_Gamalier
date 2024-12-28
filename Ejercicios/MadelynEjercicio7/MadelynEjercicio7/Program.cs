using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa el sueldo actual del empleado: ");
                double sueldoActual = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el porcentaje de aumento: ");
                double porcentajeAumento = Convert.ToDouble(Console.ReadLine());

                double aumento = sueldoActual * (porcentajeAumento / 100);

                double nuevoSueldo = sueldoActual + aumento;

                Console.WriteLine($"\nSueldo anterior: {sueldoActual}");
                Console.WriteLine($"Porcentaje de aumento: {porcentajeAumento}%");
                Console.WriteLine($"Aumento aplicado: {aumento}");
                Console.WriteLine($"Nuevo sueldo: {nuevoSueldo}");
        }
    }
}