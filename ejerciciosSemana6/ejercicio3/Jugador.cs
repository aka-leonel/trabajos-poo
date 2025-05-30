using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3) Crear la clase Integrante que posea nombre, edad, antigüedad y un 
Jugador.
Tecnico.
Jugador debe tener posicion.
Tecnico debe tener especialidad.
Crear el método sumarAntiguedad(int cantidad) que incremente el valor de la antigüedad siempre
que el valor por parametro sea superior al existente.
Crear el método sumarAntiguedad(int cantidad, string motivo) para los casos en los que se
incremente la antigüedad con un mótivo especifico. El motivo solamente debe imprimirse en
pantalla.
Instanciar en el Main al menos dos objetos de la clase Jugador y dos objetos de la clase Tecnico,
ejecutar los métodos descriptos para cada tipo de Integrante y mostrar la información final por
pantalla con un método de MostrarInformación().*/
    internal class Jugador : Integrante
    {
        public string Posicion {  get; set; }
        public Jugador(string nombre, int edad, int antiguedad, string posicion) : base (nombre, edad, antiguedad)
        {
            Posicion = posicion;
        }

        public void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Posicion: {Posicion}");
        }
    }
}
