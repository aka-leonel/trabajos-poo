using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Definir la clase Programador donde se almacene en que lenguaje de programación trabaja, si
es senior, semisenior o junior y la cantidad de veces que tumbó producción.*/
namespace ejercicio4
{
    internal class Programador : DeptoSistemas
    {
        public string[] LenguajesManejados { get; set; } = new string[0];
        public string Seniority { get; set; } = "Junior";
        public int VecesQueTumboProduccion { get; set; } = 0;

        public Programador(string nombre, string apellido, string telefono, long dni, string email, float sueldo, string areaDeTrabajo, bool poseeTitulo, bool poseeComputadoraLaboral, int personasACargo, string[] lenguajesManejados) : base(nombre,apellido, telefono, dni, email, sueldo, areaDeTrabajo, poseeTitulo, poseeComputadoraLaboral, personasACargo)
        {

        }
            public override string ToString()
        {
            string r = base.ToString() + $"\nArea: {AreaDeTrabajo} PoseeTitulo: {PoseeTitulo} PoseeComputadoraLaboral: {PoseeComputadoraLaboral}\nPersonas a cargo: {PersonasACargo}";
            if (LenguajesManejados.Length > 0)
            {
                r = r + "Lenguajes manejados: ";
                for (int i = 0; i < LenguajesManejados.Length; i++)
                {
                    r += $"\n{LenguajesManejados[i]} ";
                }
            }
            return r ;
        }
    }
}
