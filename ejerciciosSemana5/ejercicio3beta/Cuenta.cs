using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta
(nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.
*/
namespace ejercicio3beta
{
    internal class Cuenta
    {
        private int numeroCuenta;        
        private string nombreTitular;
        private int saldo;
        private string estadoCuenta;
        private static int siguienteNumero = 1;
        private DateOnly fechaNacimiento;

        public Cuenta(string nombre, DateOnly fnac)
        {            
            nombreTitular = nombre;
            fechaNacimiento = fnac;
            estadoCuenta = "Activa";
            numeroCuenta = siguienteNumero;
            siguienteNumero++;            
        }

        public static bool EsMayor(DateOnly fNac)
        {
            DateTime hoy = DateTime.Now;

            //calcular edad haciendo una resta de años.
            //si aun no paso tu cumple
            // le resta uno (adicional) a edad
            int edad = hoy.Year - fNac.Year - (fNac.DayOfYear < hoy.DayOfYear ? 0 : 1);

            if (edad > 17)
            {
                return true;
            }
            else return false;
        }
        public static bool CrearCuenta()
        {
            bool r = false;
            Console.WriteLine("Ingrese año de nacimiento:  ");
            Console.WriteLine("Ingrese mes de nacimiento (1-12): ");
            Console.WriteLine("Ingrese día: ");
            DateOnly fechaNacimiento = new DateOnly();
            return r;
        }
    }
}
