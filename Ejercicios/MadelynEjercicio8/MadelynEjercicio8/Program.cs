using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynEjercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingresa tu edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa tu sexo (H para hombre, M para mujer): ");
                char sexo = Convert.ToChar(Console.ReadLine().ToUpper());

                if (edad < 18)
                {
                    Console.WriteLine("No puedes entrar a la discoteca, eres menor de edad.");
                }
                else
                {
                    if (sexo == 'M')
                    {
                        Console.WriteLine("Puedes entrar a la discoteca ¡y entras gratis!");
                    }
                    else if (sexo == 'H')
                    {
                        Console.WriteLine("Puedes entrar a la discoteca, pero debes pagar.");
                    }
                    else
                    {
                        Console.WriteLine("Sexo inválido. Ingresa 'H' para hombre o 'M' para mujer.");
                    }
                }
            }
        }

    }

