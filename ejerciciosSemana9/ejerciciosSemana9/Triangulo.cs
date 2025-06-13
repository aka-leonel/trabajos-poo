using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*1)  Crear una clase abstracta Figura con un método abstracto CalcularArea(). Crear las clases Cuadrado, Círculo y Triángulo que hereden de Figura e implementen el método abstracto según su operación para calcular el área.*/
namespace ejercicio1
{
    internal class Triangulo :Figura
    {
        public float Base {  get; set; }
        public float Altura { get; set; }
        public Triangulo(float _base, float altura) {
            Base = _base;
            Altura = altura;
        }
        public override void CalcularArea()
        {
            float i = Base * Altura /2;
            Console.WriteLine($"El area de triangulo es {i} unidades cuadradas");
        }
    }
}
