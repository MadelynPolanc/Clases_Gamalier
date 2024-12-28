using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynArreglos2
{
    internal class Program
    {
            static void MostrarEstudiantes(string[] nombres, int[] calificaciones)
            {
                Console.WriteLine("\nLista de Estudiantes y sus Calificaciones:");
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine($"- {nombres[i]}: {calificaciones[i]}");
                }
            }

            static void Main(string[] args)
            {
                Console.Write("¿Cuántos estudiantes deseas registrar? ");
                int cantidad = int.Parse(Console.ReadLine());

                string[] nombres = new string[cantidad];
                int[] calificaciones = new int[cantidad];

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write($"Ingresa el nombre del estudiante {i + 1}: ");
                    nombres[i] = Console.ReadLine();

                    Console.Write($"Ingresa la calificación de {nombres[i]}: ");
                    calificaciones[i] = int.Parse(Console.ReadLine());
                }

                MostrarEstudiantes(nombres, calificaciones);
            }
        }

    }

