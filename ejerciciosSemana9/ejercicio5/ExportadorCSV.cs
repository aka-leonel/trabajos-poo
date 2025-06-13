using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class ExportadorCSV : IExportable
    {
        public void Exportar(string contenido)
        {
            Console.WriteLine($"Exportando a CSV: {contenido}.");
        }
    }
}
