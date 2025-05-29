using System.ComponentModel.Design;

namespace ejercicio3beta
{
    /*
     3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
    montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta
    (nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
    CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
    En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo un arreglo de objetos vacios
            // "reservo el espacio" para cinco nuevas cuentas
            Cuenta[] nuevasCuentas;
            nuevasCuentas = new Cuenta[5];

            Menu menu = new Menu(nuevasCuentas);
            
        }
    }
}
