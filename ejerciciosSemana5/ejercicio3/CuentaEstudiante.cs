using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class CuentaEstudiante : Cuenta
    {
        private bool EsAlumnoRegular;

        public CuentaEstudiante(bool esAlumnoRegular, string nombre, DateOnly fecNac) : base (nombre, fecNac)
        {
            EsAlumnoRegular = esAlumnoRegular;
        }
    }
}
