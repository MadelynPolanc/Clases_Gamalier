using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseobjeto3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudiante[] estudiantes = new Estudiante[5];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiante();

                Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");
            }
        }
    }
}
