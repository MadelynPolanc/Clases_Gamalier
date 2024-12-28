using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynArreglos1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int[,] inventario = {
            { 10, 15, 20 }, 
            { 5, 8, 12 },   
            { 25, 30, 35 }  
        };

                string[] dispositivos = { "Televisores", "Laptops", "Teléfonos" };

                Console.WriteLine("Resultados por almacén:\n");

                for (int j = 0; j < inventario.GetLength(1); j++) 
                {
                    int total = 0;
                    int mayorCantidad = int.MinValue, menorCantidad = int.MaxValue;
                    string dispositivoMayor = "", dispositivoMenor = "";

                    for (int i = 0; i < inventario.GetLength(0); i++) 
                    {
                        total += inventario[i, j];

                        if (inventario[i, j] > mayorCantidad)
                        {
                            mayorCantidad = inventario[i, j];
                            dispositivoMayor = dispositivos[i];
                        }

                        if (inventario[i, j] < menorCantidad)
                        {
                            menorCantidad = inventario[i, j];
                            dispositivoMenor = dispositivos[i];
                        }
                    }

                    Console.WriteLine($"Almacén {j + 1}:");
                    Console.WriteLine($"- Total de dispositivos: {total}");
                    Console.WriteLine($"- Dispositivo con mayor cantidad: {dispositivoMayor} ({mayorCantidad})");
                    Console.WriteLine($"- Dispositivo con menor cantidad: {dispositivoMenor} ({menorCantidad})\n");
                }
            }
        }

    }

