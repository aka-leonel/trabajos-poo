using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{/*3) Estamos desarrollando una Api Rest y debemos asegurarnos de que cada clase que creemos (las cuales representan una tabla de nuestra base de datos) tenga las posibilidades de que se puedan realizar peticiones GET(int id) para obtener información, POST(string nuevo) para crear nuevos registros, PUT(int id, string cambio) para actualizar o crear y DELETE(int id) para eliminar.*/
    internal class Cliente : IHTTPMethods
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        private static int nextId = 0;
        public Cliente(string nombre, string apellido, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Id = nextId++;
        }
        public Cliente()
        {
            Id = nextId;
            nextId++;
        }
        public void GET(int id) { }
        public void POST(string nuevo) { }
        public void PUT(int id, string cambio) { }
        public void DELETE(int id) {  }
    }
}
