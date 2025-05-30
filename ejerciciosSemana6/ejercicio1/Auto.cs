using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1) Crear la clase Vehiculo que contenga marca, modelo y anio.
Debe tener los métodos:
CambiarMarcha() (simplemente un texto que informe el cambio de marcha)
MostrarInformacion()
Luego, crear tres clases que hereden de Vehiculo
Auto
Camioneta
Moto
Agregar propiedades específicas:
Auto: CantidadPuertas, esAutomatico (booleano)
Moto: TipoManubrio
Camioneta: cantidadPuertas, es4x4 (booleano)
Se deben instanciar en el Main, creando un objeto de cada clase hija y llamar a sus métodos.*/
namespace ejercicio1
{
    internal class Auto : Vehiculo
    {
        public int CantidadPuertas {  get; set; }
        public bool EsAutomatico { get; set; }
        public Auto(string marca, string modelo, int anio, int cantidadPuertas, bool esAutomatico) : base(marca, modelo, anio)
        {
            CantidadPuertas = cantidadPuertas;
            EsAutomatico = esAutomatico;
        }
    }
}
