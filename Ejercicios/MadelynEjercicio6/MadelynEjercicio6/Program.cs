using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio6
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

                double itbis = importe * 0.18;

                double descuento = importe * 0.10;

                double totalGeneral = (importe - descuento) + itbis;

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Importe: {importe}");
                Console.WriteLine($"ITBIS (18%): {itbis}");
                Console.WriteLine($"Descuento (10%): {descuento}");
                Console.WriteLine($"Total General: {totalGeneral}");
            }
        }

    }

