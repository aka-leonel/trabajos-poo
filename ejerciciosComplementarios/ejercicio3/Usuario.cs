using ejercicio3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*La clase almacenta en el atributo List<string> Logs un historial donde se ve cuando fue creada la instancia y también registra todos los intentos -fallidos o no- de inicio y cierre de sesión.*/
    internal class Usuario : IRegistrable
    {
        public string Nombre { get; set; }
        private bool EstaEnLinea = false;
        List<string> Logs { get; set; } = new List<string>();

        public Usuario(string nombre)
        {
            Nombre = nombre;
            Logs = new List<string>();

            Logs.Add($"Se creó el usuario {Nombre}. " + DateTime.Now.ToString());
        }
        public void IniciarSesion()
        {
            if (!EstaEnLinea)
            {
                EstaEnLinea = true;                
                Logs.Add($"{Nombre} se conectó: " + DateTime.Now.ToString());
            }
            else
            {                
                Logs.Add($"Intento fallido de inicaiar sesion: {Nombre} ya estaba en linea. " + DateTime.Now.ToString());
            }
        }
        public void CerrarSesion()
        {
            if (EstaEnLinea)
            {
                EstaEnLinea = false;
               
                Logs.Add($"El usuario cerro sesion: " + DateTime.Now.ToString());
            }
            else
            {
                Logs.Add("Se intentó cerrrar sesion pero el usuario ya estaba desconectado: " + DateTime.Now.ToString());
            }
        }
        public string ObtenerLog()
        {
            string r = "";
            Console.WriteLine($"***Imprimiendo logs de {Nombre}:\n");
            foreach (var item in Logs)
            {
                r += item + "\n";
            }
            return r;
        }
    }
}
