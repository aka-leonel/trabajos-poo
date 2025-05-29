using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 6) Crear la clase Persona, con un método que compare la edad de una persona con otra.
(Se deben crear dos objetos de la clase persona, y ejecutar el método compararEdad en persona2,
pasando como parámetro la edad de persona1). */
namespace ejercicio6
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }

        public Persona(string nombre, int edad)
        {  Nombre = nombre;
            Edad = edad;
        }
        public void CompararEdad(Persona segundaPersona)
        {
            string r;
            if(segundaPersona.Edad> this.Edad)
            {
                r = $"{segundaPersona.Nombre} es mayor que {this.Nombre}.";
            } else if ( segundaPersona.Edad < this.Edad)
            {
                r = $"{segundaPersona.Nombre} es menor que {this.Nombre}.";
            } else r = $"{segundaPersona.Nombre} y {this.Nombre} tienen la misma edad.";
            Console.WriteLine(r);
        }
    }
}
