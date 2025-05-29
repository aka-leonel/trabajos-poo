using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 3) (...) definir las clases CuentaMayor, CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos. 
 * En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.*/
/* Nota: tira una excepcion si se quiere crear una cuenta mayor con una edad menor. Aún no sé manejar errores. */
namespace ejercicio3
{
    internal class CuentaMayor : Cuenta
    {
        private CuentaMayor(string nombre, DateOnly fechaNacimiento) : base(nombre, fechaNacimiento) 
        {
            if (EsMayor(fechaNacimiento))
            {
                throw new ArgumentException("La fecha indicada no corresponde a una persona mayor de edad.");
            }
            
        }

        public static void CrearCuentaMayor()
        {
            Console.WriteLine("Ingrese año de nacimiento:  ");
            Console.WriteLine("Ingrese mes de nacimiento (1-12): ");
            Console.WriteLine("Ingrese día: ");
            DateOnly fechaNacimiento = new DateOnly();
            if (EsMayor(fechaNacimiento)){
                //pedir nombre
                string nombre ="";
                while(nombre.Length < 2 )
                {
                    Console.WriteLine("Ingrese nombre: ");
                    nombre = Console.ReadLine();
                }
                CuentaMayor cn = new CuentaMayor(nombre, fechaNacimiento);

            }else{
                Console.WriteLine("La persona no es mayor de 18 años.");
                Console.WriteLine("Se sugiere crear una Cuenta Menor");
            }
        }
        
    }
}
