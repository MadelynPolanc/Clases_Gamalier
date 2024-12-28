using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynBucles2
{
    internal class Program
    {
            static void Main(string[] args)
            {
                string contraseñaCorrecta = "1234"; 
                int intentosMaximos = 3; 
                int intentos = 0;
                bool accesoConcedido = false;

                Console.WriteLine("** Sistema de autenticación **");

                while (intentos < intentosMaximos)
                {
                    Console.Write("Ingresa la contraseña: ");
                    string contraseñaIngresada = Console.ReadLine();
                    intentos++;

                    if (contraseñaIngresada == contraseñaCorrecta)
                    {
                        accesoConcedido = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta. Inténtalo nuevamente.");
                    }

                    Console.WriteLine($"Te quedan {intentosMaximos - intentos} intentos.");
                }

                if (accesoConcedido)
                {
                    Console.WriteLine("\n¡Acceso concedido! Bienvenido al sistema.");
                }
                else
                {
                    Console.WriteLine("\nHas agotado el número máximo de intentos. El programa terminará.");
                }
            }
        }

    }

