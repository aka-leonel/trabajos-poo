using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.models
{
    internal class Estudiante : Usuario, IUsuarioModulo
    {
        public Estudiante(string nombre) : base(nombre) { }

        public List<string> ListarModulos()
        {
            return new List<string>{"Ver calendario académico", "Consultar notas", "Recuperar clave"};
        }

    }
}
