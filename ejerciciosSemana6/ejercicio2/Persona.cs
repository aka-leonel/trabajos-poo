using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2) Crear la clase Persona con los siguientes atributos:
nombre
private edad
DNI
Método:
MostrarInformación() que imprima por consola los tres atributos.
Crear 3 constructores:
Uno vacío.
Uno que reciba por parametro el nombre y la edad.
Uno que reciba el nombre, la edad y el DNI.
En el Main:
Crear tres objetos de Persona usando los distintos constructores y mostrar los valores de sus propiedades con el método MostrarInformación().*/
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad;
        public long Dni;

        public Persona()
        {
            Nombre = "SinNombre";
            Edad = -1;
            Dni = -1;
        }   
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            Dni= -1;
        }

        public Persona(string nombre, int edad, long dni) {
            Nombre = nombre;
            Dni = dni;
            Edad = edad;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"{Nombre}, {Edad} años, dni: {Dni}.");
        }
    }
}
