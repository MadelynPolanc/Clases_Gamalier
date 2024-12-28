using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1clasesobjetos
{
    class Program
    {

        static void Main()
        {
            Electronico miElectronico = new Electronico();
            Console.WriteLine("Ingresa el tipo de electronico");
            miElectronico.Tipo = Console.ReadLine();
        
            Console.WriteLine("Ingresa la marca de electronico");
            miElectronico.Marca = Console.ReadLine();

            Console.WriteLine("Ingresa el color de electronico");
            miElectronico.Color = Console.ReadLine();

            miElectronico.prender();
            miElectronico.apagar();

            Console.WriteLine($"El/la {miElectronico.Tipo} es de marca {miElectronico.Marca} y tiene el color {miElectronico.Color}. ");
        }
        


}  

}
