﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoSegundoParcial
{/*
    1) Se necesita desarrollar una aplicación para administrar la información de los integrantes de un club de futbol. 
    Hay tres tipos de integrantes: jugadores, entrenadores y administrativos. 
    De todos ellos se necesita registrar su nombre, apellido y edad. 
    Además, para los jugadores se requiere ingresar la posición (entero) y la categoría (string).
    Para los entrenadores se debe registrar los años de experiencia.
    Para los administrativos la profesión y el puesto que ocupa. 
    Los jugadores y los entrenadores tienen la posibilidad de motivar a sus compañeros en la cancha, por lo que deberían tener que agregar ese método.
    Como detalle extra, necesitamos almacenar los datos de los Integrantes dentro de una estructura para poder recorrerla y mostrar la información de cada elemento.*/
    internal class Jugador : Integrante, IMotivador
    {
        int Posicion {  get; set; }
        string Categoria { get; set; }
        public Jugador(string nombre, string apellido, DateOnly fechaNacimiento, int posicion, string categoria): base(nombre, apellido, fechaNacimiento)  {
            Posicion = posicion;
            Categoria = categoria;
        }
        public static void Motivar() => Console.WriteLine($"El jugador está motivando!");
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Posición: {Posicion}. Categoria: {Categoria}.");
        }
    }
}
