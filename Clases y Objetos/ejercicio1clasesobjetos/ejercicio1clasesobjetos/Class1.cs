using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1clasesobjetos
{
     class Electronico
    {

        public string Tipo { get; set; }

        public string Color { get; set; }

        public string Marca { get; set; }


        public void prender()
        {
            Console.WriteLine("Prendiendo dispositivo");
        }
        public void apagar()
        {
            Console.WriteLine($"Apagando dispositivo.");
        }
    }
}
