using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Alumno : Persona
    {
        public string Instituto { get; set; }

        public Alumno(string nombre, string instituto) : base(nombre)
        {

        Instituto = instituto; }

        public override void Presentarse()
        {
            base.Presentarse();
            Console.WriteLine($" Y soy alumno del instituto {Instituto}");
        }

    }
}
