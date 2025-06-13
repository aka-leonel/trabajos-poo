using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
/*2) Crear una clase abstracta Empleado con los atributos Nombre, SueldoBase, y un método abstracto CalcularSueldo(). Se debe crear las clases hijas EmpleadoTiempoCompleto y EmpleadoMedioTiempo.
El empleado de tiempo completo calcula su sueldo según su sueldo base + bono de presentismo.
El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra si supero las 20 horas semanales.
*/
namespace ejercicio2
{
    internal class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, float sueldoBase) : base() {
            Nombre = nombre;
            SueldoBase = sueldoBase;
        }
        public override void CalcularSueldo()
        {
            string presentismo = "x";
            while(presentismo != "n" && presentismo != "s")
            {
                Console.WriteLine($"{Nombre} cumplió con el presentismo? s/n: ");
                presentismo = Console.ReadLine();
            }
            if (presentismo == "s") {
                float neto = SueldoBase * 1.1f;
                Console.WriteLine($"Sueldo Básico: ${SueldoBase}. Presentismo: 10%.");
                Console.WriteLine($"Neto a cobrar: ${neto}\n");
            }
            else
            {
                Console.WriteLine("No se registra presentismo.");
                Console.WriteLine($"Se cobrará el sueldo base: ${SueldoBase}.\n");
            }
            
        }
    }
}
