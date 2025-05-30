using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ejercicio N° 2:
Crear la clase Usuario y el método editarForo(nombre foro), donde se debe imprimir por consola "Soy un usuario y edito mi respuesta en el foro {nombre foro}".

Luego crear la clase hija Administrador y que el método editarForo(nombre foro) imprima "Soy el administrador y puedo configurar el foro completo"*/
namespace ejercicio2
{
    internal class Usuario
    {
        public virtual void EditarForo(string nombreForo)
        {
            Console.WriteLine($"Soy un usuario y edito mi respuesta en el foro {nombreForo}");
        }
    }
}
