using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Producto
    {        
        public string Nombre { get; set; }
        private int Stock = 0;

        public Producto(string nombre) 
        {
            Nombre = nombre;
            Stock = 0;
        }
        public void vender(int cantidad)
        {
            if(cantidad>0){
                if (Stock >= cantidad)
                {
                    Stock -= cantidad;
                    Console.WriteLine($"Se vendieron {cantidad} unidades de {Nombre}");
                }
                else
                {
                    Console.WriteLine($"No hay suficientes unidades de {Nombre}. Hay {Stock} disponibles.");
                }
            }
            else { Console.WriteLine("Cantidad debe ser mayor a cero."); }
        }
        public void sumarStock(int cantidad)
        {
            Stock += cantidad;            
        }      

        public override string ToString()
        {
            return $"{Nombre} stock: {Stock}";
        }
    }
}
