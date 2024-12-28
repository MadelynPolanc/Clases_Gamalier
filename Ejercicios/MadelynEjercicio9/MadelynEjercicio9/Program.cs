using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa el precio del artículo: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                double descuento = 0;

                if (precio >= 1000 && precio <= 5000)
                {
                    descuento = precio * 0.03; 
                }
                else if (precio >= 5001 && precio <= 10000)
                {
                    descuento = precio * 0.05; 
                }
                else if (precio >= 10001 && precio <= 15000)
                {
                    descuento = precio * 0.08; 
                }
                else if (precio >= 15001 && precio <= 20000)
                {
                    descuento = precio * 0.10; 
                }
                else
                {
                    Console.WriteLine("El precio del artículo no tiene un descuento aplicable en esta escala.");
                    return; 
                }

                double precioFinal = precio - descuento;

                Console.WriteLine($"\nPrecio original: {precio}");
                Console.WriteLine($"Descuento aplicado: {descuento}");
                Console.WriteLine($"Precio final: {precioFinal}");
            }
        }

    }

