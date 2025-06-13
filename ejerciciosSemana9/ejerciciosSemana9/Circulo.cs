using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Circulo : Figura
    {
        private float radio;
        public Circulo(float radio) : base()
        {
            this.radio = radio;
        }
        public override void CalcularArea()
        {
            float area = 0;
            area = (float)Math.Round(radio * 2 * float.Pi,2);
            Console.WriteLine($"El área del circulo de radio {radio} es de {area} unidades cuadradas.");
        }
    }
}
