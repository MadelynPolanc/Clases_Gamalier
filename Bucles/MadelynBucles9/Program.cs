using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadelynBucles9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el tamaño del triángulo (en numero): ");
            int tamaño = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tamaño; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }

        }
    }
}
