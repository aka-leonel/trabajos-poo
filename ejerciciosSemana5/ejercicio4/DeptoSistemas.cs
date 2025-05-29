using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    // DeptoSistemas es clase hija de la clase Empleado.
    // Esta clase alude a un Empleado del Departamento de sistemas.
    /* Definir la clase DptoSistemas (para el Departamento de Sistemas) que posea el área en la
que trabaja de Sistemas, si posee titulo relacionado a su trabajo, si posee una computadora laboral a
su cargo y cantidad de gente a cargo.
Definir la clase Programador donde se almacene en que lenguaje de programación trabaja, si
es senior, semisenior o junior y la cantidad de veces que tumbó producción.
Crear un método mostrar información del empleado en la clase Programador donde muestre
toda la información requerida.*/
    internal class DeptoSistemas : Empleado
    {
        public string AreaDeTrabajo { get; set; } = string.Empty;
        public bool PoseeTitulo { get; set; } = false;
        public bool PoseeComputadoraLaboral { get; set; } = false;
        public int PersonasACargo { get; set; } = 0;
       
        public DeptoSistemas(string nombre, string apellido, string telefono, long dni, string email, float sueldo, string areaDeTrabajo, bool poseeTitulo, bool poseeComputadoraLaboral, int personasACargo) : base(nombre, apellido, telefono, dni, email, sueldo)
        {
            AreaDeTrabajo = areaDeTrabajo;
            PoseeTitulo = poseeTitulo;
            PoseeComputadoraLaboral = poseeComputadoraLaboral;
            PersonasACargo = personasACargo;
           
        }
        public override string ToString()
        {
            string r = base.ToString() + $"\nArea: {AreaDeTrabajo} PoseeTitulo: {PoseeTitulo} PoseeComputadoraLaboral: {PoseeComputadoraLaboral}\nPersonas a cargo: {PersonasACargo}";
            return r;
        }
    }
}
