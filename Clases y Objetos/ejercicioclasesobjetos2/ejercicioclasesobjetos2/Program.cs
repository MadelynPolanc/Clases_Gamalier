using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclasesobjetos2
{
    class Program
    {

        static void Main()
        {
            Articulo Articulo1 = new Articulo();
            Console.WriteLine("Ingresa el nombre del primer articulo");
            Articulo1.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el precio del primer articulo");
            Articulo1.Precio = Console.ReadLine();

            Console.WriteLine("Ingresa la categoria del primer articulo");
            Articulo1.Categoria = Console.ReadLine();



            Articulo Articulo2 = new Articulo();
            Console.WriteLine("Ingresa el nombre del segundo articulo");
            Articulo2.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el precio del segundo articulo");
            Articulo2.Precio = Console.ReadLine();

            Console.WriteLine("Ingresa la categoria del segundo articulo");
            Articulo2.Categoria = Console.ReadLine();

            Console.WriteLine($"El primer articulo {Articulo1.Nombre} es de precio {Articulo1.Precio} y de la categoria {Articulo1.Categoria}");
            Console.WriteLine($"El segundo articulo {Articulo2.Nombre} es de precio {Articulo2.Precio} y de la categoria {Articulo2.Categoria}");

        }
    }
}

