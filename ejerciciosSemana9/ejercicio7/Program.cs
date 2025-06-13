namespace ejercicio7
{
    /*3) Estamos desarrollando una Api Rest y debemos asegurarnos de que cada clase que creemos (las cuales representan una tabla de nuestra base de datos) tenga las posibilidades de que se puedan realizar peticiones GET(int id) para obtener información, POST(string nuevo) para crear nuevos registros, PUT(int id, string cambio) para actualizar o crear y DELETE(int id) para eliminar.*/
    /* Explicación de la resolución:
     * Se define la clase Registro(int id, string contenido). Serán las 'filas' de la tabla.
     * Se define y crea un objeto tipo Tabla, el cual entre sus atributos tiene un List<Registro>.  
     * Al crear la tabla, un List<Registro> vacío es creado.
     * El objeto Tabla implementa los métodos de la interfaz IHTTPMethods para crear, leer, acualizar y borrar registros.
     * También implementa un metodo MostrarMenu() que hace gran parte del trabajo.
     * 
     * Si se 'traba' en algún momento solo presionar ENTER -es un Console.ReadLine() antes Console.Clear()-;
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabla tabla = new Tabla("Clientes");
            tabla.MostrarMenu();            
        }
    }
}
