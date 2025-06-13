using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Auto : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("Presioná la tecla ENTER para encender el auto ");
            Console.ReadLine();
            Console.WriteLine("Auto Encendido. A conducirc");
        }
    }
}
