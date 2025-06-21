using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Models
{
    internal class Editor : Usuario
    {
        public Editor(string nombre, string email) : base(nombre, email) { }
        public override void VerPermisos()
        {
            Console.WriteLine("Este usuario tiene permisos  de Editor.");
        }
    }
}
