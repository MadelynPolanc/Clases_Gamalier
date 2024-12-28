using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynPruebaTecnica_01 { 

class Program
{
    static char[,] asientos = new char[10, 10];

    static void Main()
    {
        EmpezarAsientos();

        while (true)
        {
            Console.WriteLine("Bienvenido al sistema de reservas del teatro.");
            Console.WriteLine("1. Mostrar mapa de asientos");
            Console.WriteLine("2. Reservar un asiento");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarAsientos();
                    break;

                case 2:
                    ReservarAsiento();
                    break;

                case 3:
                    Console.WriteLine("Gracias por usar el sistema de reservas.");
                    return;

                default:
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        }
    }

    static void EmpezarAsientos()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                asientos[i, j] = 'L'; 
            }
        }
    }

    static void MostrarAsientos()
    {
        Console.WriteLine("\n Muestra de asientos (L = Libre, X = Ocupado):");

        Console.Write("   ");
        for (int j = 0; j < 10; j++)
        {
            Console.Write($"{j + 1} ");
        }
        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i + 1:D2} "); 
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{asientos[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void ReservarAsiento()
    {
        Console.Write("Ingrese el número de fila (1-10): ");
        int fila = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Ingrese el número de asiento (1-10): ");
        int columna = int.Parse(Console.ReadLine()) - 1;

        if (fila < 0 || fila >= 10 || columna < 0 || columna >= 10)
        {
            Console.WriteLine("Error: El número de fila o asiento está fuera de rango.");
            return;
        }

        if (asientos[fila, columna] == 'L')
        {
            asientos[fila, columna] = 'X'; 
            Console.WriteLine("El asiento ha sido reservado con éxito.");
        }
        else
        {
            Console.WriteLine("El asiento ya está ocupado. Intente con otro asiento.");
        }
    }
}
}


