using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1)  Crear una clase abstracta Figura con un método abstracto CalcularArea(). Crear las clases Cuadrado, Círculo y Triángulo que hereden de Figura e implementen el método abstracto según su operación para calcular el área.*/
namespace ejercicio1
{
    internal class Cuadrado : Figura
    { 
        public int LongitudLado {  get; set; }

        public Cuadrado(int longitudLado) => LongitudLado = longitudLado; 
        public override void CalcularArea()
        {
            var i = LongitudLado * LongitudLado;
            Console.WriteLine($"El area del cuadrado de lado de {LongitudLado} metros es {i} metros cuadrados");
        }
    }
}
