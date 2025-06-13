using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1)  Crear una clase abstracta Figura con un método abstracto CalcularArea(). Crear las clases Cuadrado, Círculo y Triángulo que hereden de Figura e implementen el método abstracto según su operación para calcular el área.*/
namespace ejercicio1
{
    internal abstract class Figura
    {
        public abstract void CalcularArea();
    }
}
