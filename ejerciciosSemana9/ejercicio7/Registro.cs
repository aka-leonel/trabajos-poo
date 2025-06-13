using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Registro
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public bool Borrado { get; set; } = false;
        private static int nextId = 100;

        public Registro(string _contenido)
        {
            Contenido = _contenido;
            Id = nextId++;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} Contenido: {Contenido}.");
        }
        public void Borrar()
        {
            Borrado=true;
        }
    }
}
