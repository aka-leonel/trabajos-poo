namespace ejercicio7
{
    /*3) Estamos desarrollando una Api Rest y debemos asegurarnos de que cada clase que creemos (las cuales representan una tabla de nuestra base de datos) tenga las posibilidades de que se puedan realizar peticiones GET(int id) para obtener información, POST(string nuevo) para crear nuevos registros, PUT(int id, string cambio) para actualizar o crear y DELETE(int id) para eliminar.*/
    /* Explicación de la resolución:
     * Se define la interfaz IHTTPMethods con los métodos solicitados.
     * Se define la clase Registro(int id, string contenido). Serán las 'filas' de la Tabla.
     * Se define la clase Tabla, la cual tiene entre sus atributos un List<Registro>.  
     *      Al invocar el método constructor Tabla() se crea un List<Registro> vacío.
     * La clase Tabla implementa los métodos de la interfaz IHTTPMethods para crear, leer, acualizar y borrar registros.
     * También implementa un método MostrarMenu() que hace gran parte del trabajo.
     * 
     * Si se 'traba' en algún momento solo presionar ENTER -es un Console.ReadLine() antes de un Console.Clear()-;
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
