using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Bebida : Producto
    {        
        public bool ContieneAlcohol { get; set; }
        public Bebida(string nombre, bool  contieneAlcohol) : base(nombre)
        {
            ContieneAlcohol = contieneAlcohol;
        }

    }
}
