using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Bicicleta :IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("Presioná ENTER para subir a la bicicleta ");
            Console.ReadLine();
            Console.WriteLine("Conduciendo bicicleta!\n");
        }
    }
}
