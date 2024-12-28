using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa la edad de la primera persona: ");
                int edad1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa la edad de la segunda persona: ");
                int edad2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa la edad de la tercera persona: ");
                int edad3 = Convert.ToInt32(Console.ReadLine());

                int mayor, central, menor;

                if (edad1 >= edad2 && edad1 >= edad3) 
                {
                    mayor = edad1;
                    if (edad2 >= edad3)
                    {
                        central = edad2;
                        menor = edad3;
                    }
                    else
                    {
                        central = edad3;
                        menor = edad2;
                    }
                }
                else if (edad2 >= edad1 && edad2 >= edad3) 
                {
                    mayor = edad2;
                    if (edad1 >= edad3)
                    {
                        central = edad1;
                        menor = edad3;
                    }
                    else
                    {
                        central = edad3;
                        menor = edad1;
                    }
                }
                else 
                {
                    mayor = edad3;
                    if (edad1 >= edad2)
                    {
                        central = edad1;
                        menor = edad2;
                    }
                    else
                    {
                        central = edad2;
                        menor = edad1;
                    }
                }

                Console.WriteLine($"\nEl mayor es: {mayor}");
                Console.WriteLine($"El central es: {central}");
                Console.WriteLine($"El menor es: {menor}");
        }
    }

}

