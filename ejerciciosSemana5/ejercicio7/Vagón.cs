using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 7) Definir la clase Tren y su hija, Vagón. Se deben crear los 
 * métodos vagonLleno, ascelerar(int velocidad) y frenar. */

namespace ejercicio7
{
    internal class Vagón : Tren
    {
        public int NumeroAsientos { get; set; } = 64;
        public int CantidadDePasajeros { get; set; } = 0;

        public Vagón(int cantPasajeros) :base() {
            CantidadDePasajeros = cantPasajeros;
        }
        public Vagón() : base() { }
        public void SubirPasajeros(int pasajerosASubir)
        {
            int asientosLibres = NumeroAsientos - CantidadDePasajeros;
            if (asientosLibres>0 && asientosLibres>= pasajerosASubir)
            {
                CantidadDePasajeros += pasajerosASubir;
                Console.WriteLine($"Subieron {pasajerosASubir} al vagón. Asientos disponibles: {asientosLibres-pasajerosASubir}");
            }
            else Console.WriteLine($"No hay suficientes asientos. Disponibles {asientosLibres} asientos");
        }
        public bool VagonLleno()
        {
            return (CantidadDePasajeros >= NumeroAsientos);
        }
        
    }
}
