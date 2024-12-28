using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Madelyn
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Introduce el pago por hora: ");
                double pagoPorHora = Convert.ToDouble(Console.ReadLine());

                Console.Write("Introduce las horas trabajadas: ");
                double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

                double sueldoBruto = pagoPorHora * horasTrabajadas;

                double descuentoAFP = sueldoBruto * 0.0287; 
                double descuentoSFS = sueldoBruto * 0.0304; 

                double totalDescuentos = descuentoAFP + descuentoSFS;

                double sueldoNeto = sueldoBruto - totalDescuentos;

                Console.WriteLine("\nSueldo Bruto: " + sueldoBruto);
                Console.WriteLine("Descuento AFP: " + descuentoAFP);
                Console.WriteLine("Descuento SFS: " + descuentoSFS);
                Console.WriteLine("Total Descuentos: " + totalDescuentos);
                Console.WriteLine("Sueldo Neto: " + sueldoNeto);
            }
        }

    }

