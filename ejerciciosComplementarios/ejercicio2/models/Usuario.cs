using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.models
{
    abstract class Usuario
    {
        private int Id {  get; set; }
        public string Name { get; set; }
        private static int nextId = 0; 
        public Usuario(string nombre)
        {
            Name = nombre;
            Id = nextId++;
        }
    }
}
