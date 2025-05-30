using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3) Crear la clase Integrante que posea nombre, edad, antigüedad y un único método constructor que
almacene los datos de las variables nombradas.
Crear el método sumarAntiguedad(int cantidad) que incremente el valor de la antigüedad siempre
que el valor por parametro sea superior al existente.
Crear el método sumarAntiguedad(int cantidad, string motivo) para los casos en los que se
incremente la antigüedad con un mótivo especifico. El motivo solamente debe imprimirse en
pantalla.
Instanciar en el Main al menos dos objetos de la clase Jugador y dos objetos de la clase Tecnico,
ejecutar los métodos descriptos para cada tipo de Integrante y mostrar la información final por
pantalla con un método de MostrarInformación().*/

    internal class Integrante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Antiguedad { get; set; }

        public Integrante(string nombre, int edad, int antiguedad)
        {

            Nombre = nombre;
            Edad = edad;
            Antiguedad = antiguedad;
        }

        public void SumarAntiguedad(int cantidad)
        {
            if (cantidad > 0)
            {
                Antiguedad += cantidad;
                Console.WriteLine($"Se le sumaron {cantidad} años de antiguedad a {Nombre}");
            }
            else Console.WriteLine("Solo se aceptan valores positivos.");
        }

        public void SumarAntiguedad(int cantidad, string motivo)
        {
            if (cantidad > 0)
            {
                Antiguedad += cantidad;
                Console.WriteLine($"Se sumaron {cantidad} años de antigüedad a {Nombre} por {motivo}");

            }
            else Console.WriteLine("Solo se aceptan valores positivos.");
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}. Edad: {Edad} años. Antigüedad: {Antiguedad} años.");
        }
    }
}
