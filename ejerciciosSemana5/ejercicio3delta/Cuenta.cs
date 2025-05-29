using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta
(nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.

 */
namespace ejercicio3delta
{
    internal class Cuenta
    {
        public int NumeroCuenta {  get; set; }
        public string NombreTitular { get; set; }
        public int Saldo { get; set; }
        public string EstadoCuenta { get; set; }
        private static int SiguienteNumero = 1;

        public Cuenta()
        {
            Console.WriteLine("Ingrese nombre del titular: ");
            NombreTitular = Console.ReadLine();
            NumeroCuenta = SiguienteNumero;
            SiguienteNumero++;
            Saldo = 0;
            EstadoCuenta = "Activa";

            MostrarInfo();
        }

        public void IngresarMonto(int montoAIngresar)
        {
            if (montoAIngresar > 0)
            {
                Saldo += montoAIngresar;
                Console.WriteLine($"Se ha ingresado ${montoAIngresar}");
            }
            else
            {
                Console.WriteLine("El monto debe ser mayor a cero.");
            }
        }

        public void RetirarMonto(int montoARetirar)
        {
            if(montoARetirar > Saldo)
            {
                Console.WriteLine($"No tiene fondos suficientes. Saldo disponible ${Saldo}");
            }else
            {
                Saldo -= montoARetirar;
                Console.WriteLine($"Retiraste ${montoARetirar} de tu cuenta.");
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Cuenta Nº: {NumeroCuenta} Titular: {NombreTitular}");
            Console.WriteLine($"Saldo: ${Saldo}. Estado de cuenta: {EstadoCuenta}");
        }

    }
}
