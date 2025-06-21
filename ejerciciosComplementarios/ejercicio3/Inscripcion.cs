using ejercicio3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejercicio3
{
    internal class Inscripcion : IRegistrable
    {
        public int NumeroOperacion { get; set; }
        public Curso Curso { get; set; }
        public Usuario Usuario { get; set; }
        private static int proximoNumeroOperacion = 100;
        public List<string> Logs = new List<string>();

        public Inscripcion(Usuario usuario,Curso curso)
        {
            Usuario = usuario;
            Curso = curso;
            NumeroOperacion = proximoNumeroOperacion++;
            string fechaInsc = DateTime.Now.ToString();
            Logs.Add($"Incripcion realizada: "+ fechaInsc);
        }

        public string ObtenerLog()
        {
            string r = "";
            Console.WriteLine($"***Imprimiendo logs de la inscripcion de {Usuario.Nombre}:\n");
            foreach (var item in Logs)
            {
                r += item + "\n";
            }
            return r;
        }
    }
}
