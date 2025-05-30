using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre}.");
        }
    }
}
