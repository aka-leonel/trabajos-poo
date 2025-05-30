namespace ejercicio2
{
    /*Ejercicio N° 2:
Crear la clase Usuario y el método editarForo(nombre foro), donde se debe imprimir por consola "Soy un usuario y edito mi respuesta en el foro {nombre foro}".

Luego crear la clase hija Administrador y que el método editarForo(nombre foro) imprima "Soy el administrador y puedo configurar el foro completo"*/

    /*Nota: siguiendo con lo pedido, el metodo EditarForo(string foro) ha sido sobreescrito por la clase Administrador con esa misma firma, es decir recibiendo un string que no se mostrará por pantalla. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Administrador administrador = new Administrador();
            usuario.EditarForo("Foro de pesca");
            administrador.EditarForo("este texto no se imprimira en pantalla.");
        }
    }
}
