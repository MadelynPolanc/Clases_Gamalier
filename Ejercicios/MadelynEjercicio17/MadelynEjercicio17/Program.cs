using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa el sueldo bruto del empleado: ");
                double sueldoBruto = Convert.ToDouble(Console.ReadLine());

                double descuentoAFP = sueldoBruto * 0.0287;  
                double descuentoSFS = sueldoBruto * 0.0304;  

                double descuentoISR = 0.0;
                string mensajeISR = "No Aplica";  

                if (sueldoBruto > 416220) 
                {
                    if (sueldoBruto <= 624330)  
                    {
                        descuentoISR = (sueldoBruto - 416220) * 0.15;
                        mensajeISR = $"ISR: {descuentoISR}";
                    }
                    else if (sueldoBruto <= 867123)  
                    {
                        descuentoISR = (sueldoBruto - 624330) * 0.20 + (624330 - 416220) * 0.15;
                        mensajeISR = $"ISR: {descuentoISR}";
                    }
                    else  
                    {
                        descuentoISR = (sueldoBruto - 867123) * 0.25 + (867123 - 624330) * 0.20 + (624330 - 416220) * 0.15;
                        mensajeISR = $"ISR: {descuentoISR}";
                    }
                }

                double sueldoNeto = sueldoBruto - (descuentoAFP + descuentoSFS + descuentoISR);

                Console.WriteLine($"\nSueldo Bruto: {sueldoBruto}");
                Console.WriteLine($"Descuento AFP: {descuentoAFP}");
                Console.WriteLine($"Descuento SFS: {descuentoSFS}");
                Console.WriteLine(mensajeISR);
                Console.WriteLine($"Sueldo Neto: {sueldoNeto}");
        }
    }
 }

