using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Moto :IVehiculo
    {
        public Moto() { }
        public void Conducir()
        {
            Console.WriteLine("Presioná ENTER para subir a la moto");
            Console.ReadLine();
            Console.WriteLine("Estás arriba de la moto. A conducir!\n");
        }
    }
}
