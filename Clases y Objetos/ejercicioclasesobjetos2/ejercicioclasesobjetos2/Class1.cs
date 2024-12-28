using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclasesobjetos2
{
    class Articulo
    {
        public string Nombre { get; set; }

        public string Precio { get; set; }

        public string Categoria { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Informacion del articulo");
        }
    

    }
}
