using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3gamma
{
    internal class Cuenta
    {
        private int numeroCuenta;
        private string nombreTitular;
        private int saldo;
        private string estadoCuenta;
        private static int siguienteNumero = 1;
        
        public Cuenta()
        {            
            this.nombreTitular = Console.ReadLine();
            this.numeroCuenta = siguienteNumero;
            siguienteNumero++;
            this.saldo = 0;
            this.estadoCuenta = "Activa";
            Console.WriteLine($"Cuenta creada id {numeroCuenta}.");
        }
        public void ingresarMonto(int montoASumar) 
        {
            if ( montoASumar > 0)
            {
                saldo += montoASumar;
            }
            else
            {
                Console.WriteLine("Monto invalido. Debe ser mayor a cero.");
            }
        }

        public void retirarMonto(int montoARetirar)
        {
            if( montoARetirar <= saldo)
            {
                saldo -= montoARetirar;
                Console.WriteLine($"Retiraste: ${montoARetirar}. Saldo disponible: ${saldo}");
            }
            else
            {
                Console.WriteLine($"No tiene monto suficiente. Monto disponible ${saldo}.");
            }
        }
        public void mostrarInformacion()
        {
            Console.WriteLine($"Cuenta Nº: {numeroCuenta}. Titular {nombreTitular}");
            Console.WriteLine($"Saldo ${saldo}. Estado: {estadoCuenta}");
        }
    }
}
