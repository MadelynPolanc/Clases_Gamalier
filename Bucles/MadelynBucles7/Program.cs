using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynBucles7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el número para generar su tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

        }
    }
}
