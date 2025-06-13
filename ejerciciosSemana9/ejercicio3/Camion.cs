using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Camion : Vehiculo
    {
        public Camion() { }
        public override void Arrancar()
        {
            EstaEncendido = true;
            Console.WriteLine("Arrancó el camión.");
        }
        public override void MostrarTipo()
        {
            Console.WriteLine("Este vehículo es un camión.");
        }
    }
}
