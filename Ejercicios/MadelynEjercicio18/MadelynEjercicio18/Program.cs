using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double produccionLunes, produccionMartes, produccionMiercoles, produccionJueves, produccionViernes;
                double totalProduccion, promedioProduccion, incentivo;

                Console.Write("Ingresa la producción del lunes: ");
                produccionLunes = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la producción del martes: ");
                produccionMartes = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la producción del miércoles: ");
                produccionMiercoles = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la producción del jueves: ");
                produccionJueves = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa la producción del viernes: ");
                produccionViernes = Convert.ToDouble(Console.ReadLine());

                totalProduccion = produccionLunes + produccionMartes + produccionMiercoles + produccionJueves + produccionViernes;

                promedioProduccion = totalProduccion / 5;

                if (promedioProduccion >= 20000)
                {
                    incentivo = 3000;  
                    Console.WriteLine($"Sí aplica y tiene un incentivo de RD${incentivo:F2}");
                }
                else
                {
                    incentivo = 0;  
                    Console.WriteLine("Incentivo: N/A");
                }

                Console.WriteLine($"\nTotal de la producción de la semana: {totalProduccion:F2} unidades");
                Console.WriteLine($"Promedio de la producción semanal: {promedioProduccion:F2} unidades");
            }
        }

    }

