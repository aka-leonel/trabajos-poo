using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3gamma
{
    internal class CuentaMayor : Cuenta
    {
        private CuentaMayor(): base () { }   
        public static CuentaMayor CrearCuentaMayor()  {
            Console.WriteLine("Es la persona mayor de edad?");
            string r = "n";
            CuentaMayor nc = null;
            r = Console.ReadLine();
            if (r == "s") 
            {
                nc = new CuentaMayor();
                Console.WriteLine("Cuenta crada");
                return nc;
            }
            return nc;
        }

    }
}
