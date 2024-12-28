using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa el sueldo del empleado: ");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el número de hijos del empleado: ");
                int numeroDeHijos = Convert.ToInt32(Console.ReadLine());

                double incentivo = 0;

                if (numeroDeHijos > 0)
                {
                    incentivo = numeroDeHijos * 500; 
                }

                Console.WriteLine($"\nSueldo del empleado:{sueldo}");
                Console.WriteLine($"Número de hijos: {numeroDeHijos}");

                if (incentivo > 0)
                {
                    Console.WriteLine($"Incentivo por hijos:{incentivo}");
                }
                else
                {
                    Console.WriteLine("Incentivo: N/A (No tiene hijos)");
                }
        }
    }

}

