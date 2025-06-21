using ejercicio3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Curso : IRegistrable
    {
        public string Nombre { get; set; }
        public List<string> EquipoDocente = new List<string>();
        public List<string> Logs = new List<string>();
        public Curso(string nombre) { Nombre = nombre; }
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

        public void AgregarDocente(string doc)
        {
            EquipoDocente.Add(doc);
            string m = $"Se sumó {doc} al equipo docente.";
            Logs.Add(m + DateTime.Now.ToString());
            //Console.WriteLine(m);
        }
        public void RemoverDocente(string doc)
        {
            string m;
            if (EquipoDocente.Remove(doc))
            {
                m = $"Se removió a {doc} del equipo docente.";
            }
            else { m = $"Error al remover a {doc} del listado docente: no se encuentra"; }
            Logs.Add(m);
        }
    }
}
