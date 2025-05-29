/*3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta
(nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.

 */
using System.ComponentModel.Design;

namespace ejercicio3gamma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta[] listaDeCuentas;//lista vacia
            listaDeCuentas = new Cuenta[5];
           // Menu(listaDeCuentas);
            Bebida.nombre = ""

    
        }

        public Cuenta Menu(Cuenta[] lista) {
        int lugaresDisponbles = lista.Length;
        
        //intento crear cuenta mayor
        Console.WriteLine("--- Creacion de cuenta bancaria. ---");
        Console.WriteLine("Qué tipo de cuenta quiera crear?:");
        Console.WriteLine("1. Cuenta Mayor");
        Console.WriteLine("2. Cuenta Menor");
        Console.WriteLine("3. Cuenta Estudiante");
        string opcion;
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                //do
                CuentaMayor.CrearCuentaMayor();
                break;
            case "2":
                //do
                break;
            case "3":
                //do
                break;
            case "4":
                Console.WriteLine("--- Salir del programa ---");
                break;
            default:
                Console.WriteLine("Ingrese una opcion valida");
                break;
        }


    }
}
