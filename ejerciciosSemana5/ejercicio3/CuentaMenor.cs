using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class CuentaMenor : Cuenta
    {
        //para darle algo caracteristico a la clase se le establecio
        //un limite diario de extraccion con un valor arbitrario
        private int limiteExtraccionDiaria = 10000;
        public CuentaMenor(string nombre, DateOnly fn) : base(nombre, fn)
        {
            Console.WriteLine("Tipo de Cuenta: Cuenta Menor.");
        }

        public override void RetirarMonto(int monto)
        {
            if (monto > limiteExtraccionDiaria)
            {
                Console.WriteLine("Exede el límite diario de extracción.");
                Console.WriteLine($"Su límite de extracción diario es ${limiteExtraccionDiaria}.");
            }
            else
            {
                base.RetirarMonto(monto);
            }
        }
    }
}
