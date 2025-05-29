using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Circulo : Figura
    {
        private double Radio;
        public Circulo(double radio): base(1) {
            Radio = radio;
        }
        public override double CalcularArea()
        {
            return Radio * Math.PI;
        }
    }
}
