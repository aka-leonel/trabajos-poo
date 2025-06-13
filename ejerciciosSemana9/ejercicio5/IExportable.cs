using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Se nos requiere que la información se pueda descargar en Excel, PDF y CSV.
Por lo que se nos ocurre una idea para manejar todos los tipos de Exportables como una sola clase, por lo que creamos la Interfaz IExportable con método Exportar(string contenido) y
se la aplicamos a las clases ExportarXLS, ExportarPDF y  ExportarCSV.
Nuestro main debería permitirnos instanciar cualquier tipo de clase que implemente la interfaz y ejecutar el método exportar().
Código de ejemplo del main:
string contenido = "Este es el informe de las personas encuestadas.";

IExportable[] exportadores = new IExportable[3];
exportadores[0] = new ExportadorPDF();
exportadores[1] = new ExportadorPDF();
exportadores[2] = new ExportadorCSV();
 foreach (IExportable exportador in exportadores)
       {
            exportador.Exportar(contenido);
        } */
namespace ejercicio5
{
    internal interface IExportable
    {
        public void Exportar(string contenido);
    }
}
