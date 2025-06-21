using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.models
{
    internal class Dedu : Usuario, IUsuarioModulo
    {
        public Dedu(string nombre): base(nombre) { }

        public List<string> ListarModulos() {  return new List<string>{ "Gestión de Cursos", "Estadísticas", "Soporte", "Administración" }; }
        
    }
}
