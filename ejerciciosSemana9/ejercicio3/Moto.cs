using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Moto : Vehiculo
    {
        public Moto() { }
        public override void Arrancar()
        {
            EstaEncendido = true;
            Console.WriteLine("Arrancó la moto.");
        }
        public override void MostrarTipo()
        {
            Console.WriteLine("Este vehículo es una moto.");
        }
    }
}
