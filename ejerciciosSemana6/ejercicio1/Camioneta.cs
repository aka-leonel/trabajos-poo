using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Camioneta : Vehiculo
    {
        public int CantidadPuertas {  get; set; }
        public bool Es4x4 {  get; set; }
        public Camioneta(string marca, string modelo, int anio, int cantidadPuertas , bool es4x4) : base (marca, modelo, anio)
        {
            CantidadPuertas = cantidadPuertas;
            Es4x4 = es4x4;
        }
    }
}
