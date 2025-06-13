using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class ExportadorPDF : IExportable
    {
        public void Exportar(string contanido)
        {
            Console.WriteLine($"Exportando a PDF: {contanido}.");
        }
    }
}
