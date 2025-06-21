using ejercicio1.Controllers;
using ejercicio1.Models;

namespace ejercicio1
{
    /*1) Sistema de Usuarios con Roles
Se desea un sistema que tenga distintos tipos de usuario: Admin, Editor y Lector (clases hijas de Usuario). Cada tipo de usuario tiene permisos distintos que se deben implementar mediante un método VerPermisos().

---Estructura
Modelos:
Usuario (abstracta): Nombre, Email, método abstracto VerPermisos().
Admin, Editor, Lector: sobreescriben(override) VerPermisos().
Controlador: 
Lista de usuarios (List<Usuario>)
Métodos: agregar usuario y mostrar permisos.*/
    /* Se siguió  el ejemplo visto en clase: se creo una clase padre abstracta (Usuarios) y sus clases hijas(Editor, Lector, Admin). Luego en la carpeta controllers se creo el controlador de esta clase (UsuarioController).*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // se crea una instancia del controlador
            // el cual precarga la lista con un usuario de cada tipo
            UsuarioController usuarioController = new UsuarioController();

            // se muestra el listado de usuarios creado por el controlador
            usuarioController.MostrarTodos();

            Console.WriteLine("Se añadirán dos usuarios más.");
            Console.ReadKey();
            usuarioController.AddUsuario(new Lector("pablo", "pablo@mail.com"));
            usuarioController.AddUsuario(new Editor("Marina", "mari@na.com"));

            usuarioController.MostrarTodos();


        }
    }
}
