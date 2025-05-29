using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Alimento : Producto
    {
        public bool ContieneTACC { get; set; }
        public Alimento(string nombre, bool contieneTACC): base(nombre)
        {
            ContieneTACC = contieneTACC;
        }
    }
}
