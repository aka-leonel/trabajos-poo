namespace ejercicio5
{
    /* Ejercicios de interfaces
     * 1) Nos encontramos desarrollando una aplicación para administrar, recopilar y procesar información para un set de datos de personas que fueron encuestadas con la finalidad de ofrecer una segmentación del mercado. 
Se nos requiere que la información se pueda descargar en Excel, PDF y CSV.
Por lo que se nos ocurre una idea para manejar todos los tipos de Exportables como una sola clase, por lo que creamos la Interfaz IExportable con método Exportar(string contenido) y
se la aplicamos a las clases ExportarPDF, ExportarPDF y  ExportarCSV.
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
        }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /* IExportable[] exportadores = new IExportable[3];
             exportadores[0] = new ExportadorXLS();
             exportadores[1] = new ExportadorPDF();
             exportadores[2] = new ExportadorCSV();

             foreach (var item in exportadores)
             {
                 item.Exportar("")
             }*/
            string contenido = "Este es el informe de las personas encuestadas.";

            IExportable[] exportadores = new IExportable[3];
            exportadores[0] = new ExportadorPDF();
            exportadores[1] = new ExportadorPDF();
            exportadores[2] = new ExportadorCSV();
            foreach (IExportable exportador in exportadores)
            {
                exportador.Exportar(contenido);
            }
        }
    }
}
