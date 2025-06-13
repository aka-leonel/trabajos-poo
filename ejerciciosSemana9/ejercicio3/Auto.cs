using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Auto : Vehiculo
    {
        public Auto() { }
        public override void Arrancar()
        {
            EstaEncendido = true;
            Console.WriteLine("Arrancó el auto");
        }
        public override void MostrarTipo()
        {
            Console.WriteLine("Este vehículo es un auto.");
        }
    }
}
