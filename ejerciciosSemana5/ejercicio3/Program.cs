/*
 * 3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta (nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor, CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos. 
 * En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.*/
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string nombre = "Ada";
            DateOnly fNac = new DateOnly(2000, 1, 14);
            Console.WriteLine(CuentaMayor.EsMayor(fNac));

            //CuentaMenor cuenta = new CuentaMenor(nombre, fNac);
            //cuenta.IngresarMonto(5000);
            //cuenta.RetirarMonto(60000);
        }

       
    }
  
}
