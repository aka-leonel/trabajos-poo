using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal abstract class Figura
    {
        private int lados;
        public abstract double CalcularArea();
        public Figura(int _lados) { lados = _lados; }    

    }
}
