using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 id: int
nombre: string
apellido: string
telefono: string
email: string
dni: string
sueldo: float
*/
namespace ejercicio4
{
    internal class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono {  get; set; } 
        public long Dni {  get; set; }
        public string Email {  get; set; } = string.Empty;
        public float Sueldo { get; set; }
        private static int siguienteId = 1;
        public Empleado(string nombre, string apellido, string telefono, long dni, string email, float sueldo) {
            IdEmpleado = siguienteId;
            siguienteId++;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Dni = dni;
            Email = email;
            Sueldo = sueldo;
        }

        public override string ToString()
        {            
            return $"id:{IdEmpleado} Apellido, nombre: {Apellido}, {Nombre} DNI: {Dni}\nTelefono: {Telefono} Email: {Email}\nSueldo: ${Sueldo}";
        }
    }
}
