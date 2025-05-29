using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta (nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor, CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos. 
 * En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.*/

/*Notas: 
 * Para simplificar sólo se declaró la variable nombreTitular y se omitió el apellido
 * La variable saldo y todas las funciones que con ella trabajan, son de tipo int.
 * estado_cuenta Lo pensé primero como un booleano, pero lo dejé como string pensando en la posibilidad de varios estados posibles (activa, inactiva, pausada, etc)
 */
namespace ejercicio3
{
    internal class Cuenta
    {
        private int nro_cuenta;
        private static int siguiente_nro_cuenta = 1;
        private int saldo;
        private string nombreTitular;
        protected string estado_cuenta;
        private DateOnly fechaNacimiento;
        public Cuenta(string nombre, DateOnly fechaNacimiento)
        {
            this.nro_cuenta = siguiente_nro_cuenta;
            siguiente_nro_cuenta++;
            this.nombreTitular = nombre;
            estado_cuenta = "Activa";
            this.fechaNacimiento = fechaNacimiento;
            this.saldo = 0;
            Console.WriteLine($"Creada cuenta numero: {nro_cuenta} a nombre de {nombreTitular}.");
        }
        public void IngresarMonto(int monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine($"Se ingresó {monto} en la cuenta.");
                Console.WriteLine($"Saldo actual: {saldo}");
            }
            else
            {
                Console.WriteLine("El monto ingresado debe ser mayor a cero.");
            }
        }
        public virtual void RetirarMonto(int monto)
        {
            if (monto > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                Console.WriteLine("Disponible: $", saldo);
            }
            else
            {
                saldo -= monto;
                Console.WriteLine($"Retiraste ${monto} de la cuenta de {nombreTitular}.");
                Console.WriteLine($"Saldo actual: ${saldo}");
            }
        }

        /*mostrar información de la cuenta (nro_cuenta, nombre, saldo, estado_cuenta)*/
        public void MostrarInformacion()
        {
            Console.WriteLine("--- Información de Cuenta ---");
            Console.WriteLine($"Titular: {nombreTitular} nroCuenta: {nro_cuenta}");
            Console.WriteLine($"Saldo ${saldo}. Estado de cuenta: {estado_cuenta}");
        }

        //funcion publica y estatica para verificar edad antes de crear el nuevo objeto
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
    }
}
