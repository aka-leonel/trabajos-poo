/* 7) Definir la clase Tren y su hija, Vagón. Se deben crear los 
 * métodos vagonLleno, ascelerar(int velocidad) y frenar. */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Tren
    {
        public int Velocidad { get; set; } = 0;

        public void Acelerar(int v)
        {
            if (Velocidad < v)
            {
                Velocidad = v;
                Console.WriteLine($"La velocidad del tren es de {Velocidad} km/h");
            }
        }
        public void Frenar()
        {
            Velocidad = 0;
            Console.WriteLine("El tren ha frenado");
        }
    }
}
