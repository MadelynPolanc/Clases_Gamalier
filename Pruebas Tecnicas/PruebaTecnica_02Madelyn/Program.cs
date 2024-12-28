using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica_02Madelyn
{
    internal class Program
    {
            static void Main(string[] args)
            {
                const int estudiantesCount = 2;

                for (int i = 1; i <= estudiantesCount; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Registro academico: Estudiante {i}");
                    RegistrarDatosEstudiante(i);
                }
            }

            static void RegistrarDatosEstudiante(int idEstudiante)
            {
                var estudiante = new Estudiante();
                estudiante.Asignaturas = new List<Asignatura>();

                Console.Write("Ingrese el nombre del estudiante: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write("Ingrese la edad del estudiante: ");
                estudiante.Edad = Convert.ToInt32(Console.ReadLine());

                const int cantidadAsignaturas = 3;
                for (int j = 1; j <= cantidadAsignaturas; j++)
                {
                    var asignatura = new Asignatura();

                    Console.Write($"Asignatura {j} que está cursando: ");
                    asignatura.Nombre = Console.ReadLine();

                    Console.Write($"¿Cuál es la calificación de {asignatura.Nombre}? ");
                    asignatura.Calificacion = Convert.ToDouble(Console.ReadLine());

                    estudiante.Asignaturas.Add(asignatura);
                }

                MostrarDetallesEstudiante(estudiante, idEstudiante);
            }

            static void MostrarDetallesEstudiante(Estudiante estudiante, int idEstudiante)
            {
                Console.WriteLine($"\nDetalles del estudiante {idEstudiante}:");
                Console.WriteLine($"Nombre: {estudiante.Nombre}");
                Console.WriteLine($"Edad: {estudiante.Edad}");
                Console.WriteLine("Asignaturas y calificaciones:");

                double totalNotas = 0;
                foreach (var asignatura in estudiante.Asignaturas)
                {
                    Console.WriteLine($"- {asignatura.Nombre}: {asignatura.Calificacion:F2}");
                    totalNotas += asignatura.Calificacion;
                }

                double promedio = totalNotas / estudiante.Asignaturas.Count;
                Console.WriteLine($"Promedio de calificaciones: {promedio:F2}");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        public class Estudiante
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public List<Asignatura> Asignaturas { get; set; }
        }

        public class Asignatura
        {
            public string Nombre { get; set; }
            public double Calificacion { get; set; }
        }

    }

