using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Moto : Vehiculo
    {
        public string TipoManubrio;

        public Moto(string marca, string modelo, int anio, string tipoManubrio) : base (marca, modelo, anio)
        {
            TipoManubrio = tipoManubrio;
        }
    }
}
