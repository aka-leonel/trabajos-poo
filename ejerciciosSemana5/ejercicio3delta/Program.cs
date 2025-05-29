/*3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta
(nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.

 */
using System.ComponentModel.Design;

namespace ejercicio3delta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta[] listadoDeCuentas = new Cuenta[3];
            Menu(listadoDeCuentas);
            Console.Clear();
            Console.WriteLine("--Finalizo el menu");
            for (int i = 0; i < listadoDeCuentas.Length; i++)
            {
                if(listadoDeCuentas[i] != null)
                {
                    listadoDeCuentas[i].MostrarInfo();
                }
                
            }
        }



        public static void Menu(Cuenta[] listado)
        {
            int espaciosLibres = listado.Length;
            int i = 0;
            string opcion = "-1";
            while (espaciosLibres > 0 && opcion != "4")
            {
                //mostrar menu , crear etc
                Console.WriteLine("-- Crear Cuenta --");
                Console.WriteLine($"Lugares disponibles{espaciosLibres}");
                Console.WriteLine("1. Cuenta Mayor");
                Console.WriteLine("2. Cuenta Menor");
                Console.WriteLine("3. Cuenta Estudiante");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        //cuentamayor
                        Console.WriteLine("Es mayor de 18 años? s/n: ");
                        string op = Console.ReadLine();
                        if (op == "s")
                        {
                            //creo la clase
                            listado[i] = new CuentaMayor();
                            i++;
                            espaciosLibres--;
                        }
                        else
                        {
                            Console.WriteLine("La persona debe ser mayor de edad. Si es menor se sugiere una cuenta menor.");
                        }
                        break;
                    case "2":
                        //cuentamenor
                        Console.WriteLine("Es menor de 18 años? s/n: ");
                        string op2 = Console.ReadLine();
                        if (op2 == "s")
                        {
                            listado[i] = new CuentaMenor();                         
                            i++;
                            espaciosLibres--;
                        }
                        else { Console.WriteLine("Se sugiere crear una cuenta mayor"); }
                        break;
                    case "3":
                        //cuenta stud
                        listado[i] = new CuentaEstudiante();
                        i++;
                        espaciosLibres--;

                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
                //si creo algo restar un espacio libre
            }
            
        }
    }
}
