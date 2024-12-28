using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa la cantidad del artículo: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el precio del artículo: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                double importe = cantidad * precio;

                Console.WriteLine($"\nEl importe total del artículo es: {importe}");
        }
    }

}

