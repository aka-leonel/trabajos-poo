using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Triangulo : Figura
    {
        private double Base;
        private double Altura;
        public override double CalcularArea()
        {
            return (Base * Altura / 2);
        }
        public Triangulo(double Base, double Altura) : base(3)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
    }
}
