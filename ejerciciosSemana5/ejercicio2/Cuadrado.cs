using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Cuadrado : Figura
    {
        private double longlado;
        public Cuadrado(double longitud) : base (4)
        {
            this.longlado = longitud;
        }
        public override double CalcularArea()
        {
            return longlado*longlado;
        }
    }
}
