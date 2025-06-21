using ejercicio3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.controllers
{
    /*Controlador:
Lista de objetos IRegistrable
Generar reporte de logs de actividad*/
    internal class RegistrableController
    {
        public List<IRegistrable> entidades = new List<IRegistrable>();

        public RegistrableController() { }

        public void MostrarLogs()
        {
            foreach (var item in entidades)
            {
                string auxLog = item.ObtenerLog();
                Console.WriteLine(auxLog);
            }
        }
    }
}
