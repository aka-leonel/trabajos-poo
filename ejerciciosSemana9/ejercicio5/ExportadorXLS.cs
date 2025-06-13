using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class ExportadorXLS : IExportable
    {
        public void Exportar(string contenido)
        {
            Console.WriteLine($"Exportando a XLS: {contenido}.");
        }
    }
}
