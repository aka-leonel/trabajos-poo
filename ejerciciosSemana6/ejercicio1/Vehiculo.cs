using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1) Crear la clase Vehiculo que contenga marca, modelo y anio.
Debe tener los métodos:
CambiarMarcha() (simplemente un texto que informe el cambio de marcha)
MostrarInformacion()
*/
    internal class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Marcha { get; set; } = 0;
        public Vehiculo(string marca, string modelo, int anio)
        {
            Modelo = modelo;
            Anio = anio;
            Marca = marca;
        }

        public void CambiarMarcha()
        {
            if (Marcha == 0)
            {
                Marcha = 1;
            }
            else Marcha = 0;
            Console.WriteLine($"{Modelo} cambió a marcha {Marcha}.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca} Modelo: {Modelo} Año: {Anio} Marcha: {Marcha}");
        }
    }
}
