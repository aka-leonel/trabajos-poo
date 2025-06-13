using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra si supero las 20 horas semanales.
*/
namespace ejercicio2
{
    internal class EmpleadoMedioTiempo : Empleado
    {
        public EmpleadoMedioTiempo(string nombre, float sueldoBase) : base()
        {
            Nombre = nombre;
            SueldoBase = sueldoBase;
        }

        public override void CalcularSueldo()
        {
            string op = "x";
            while (op != "s" && op != "n")
            {
                Console.WriteLine($"{Nombre} trabajó más de 20 horas semanales? s/n: ");
                op = Console.ReadLine();
            }
            if (op == "s")
            {
                float neto = SueldoBase * 1.1f;
                Console.WriteLine($"Sueldo base: ${SueldoBase}. Bonificacion del 10% por presentismo.");
                Console.WriteLine($"Neto a cobrar: ${neto}\n");
            }
            else
            {
                Console.WriteLine("No trabajó más de 20hs semanales.");
                Console.WriteLine($"Se cobrará el sueldo base: ${SueldoBase}.\n");

            }
        }
    }
}
