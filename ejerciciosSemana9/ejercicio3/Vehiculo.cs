using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3) Crear la clase abstracta Vehiculo con método abstracto Arrancar() y un método no abstracto que sea acelerar(). Crear las clases hijas Auto, Moto y Camion que implementen Arrancar().
En el Main, crear un arreglo de Vehículos y que ejecuten el método arrancar y acelerar.

Código de ejemplo del main:
        Vehiculo[] vehiculos = new Vehiculo[3];
        vehiculos[0] = new Auto();
        vehiculos[1] = new Moto();
        vehiculos[2] = new Camion();
        foreach (Vehiculo v in vehiculos)
        {
            v.MostrarTipo();
            v.Arrancar();
            Console.WriteLine();
        }*/
namespace ejercicio3
{
    internal abstract class Vehiculo
    {
        protected bool EstaEncendido = false;
        public abstract void Arrancar();
        public abstract void MostrarTipo();
        public void Acelerar()
        {
            if (EstaEncendido)
            {
                Console.WriteLine("El vehiculo acelera.");
            } else Console.WriteLine("No se puede acelerar, el motor está apagado.");
        }

    }
}
