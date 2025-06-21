using ejercicio2.controllers;

namespace ejercicio2
{
    /*2) Gestión de Módulos por Tipo de Usuario

Se requiere una plataforma que posea distintos módulos: Gestión de Cursos, Estadísticas, Soporte, etc. Según el tipo de usuario (IDedu, IUA, IEstudiante), puede o no acceder a ciertos módulos.

Estructura:
Modelos:
Interfaz IUsuarioModulo con método ListarModulos()
Clases Dedu, UA, Estudiante (implementan esa interfaz)
Controlador:
Lista de usuarios y módulos disponibles
Método para listar los módulos accesibles por usuario
/ para este caso /
Se pueden implementar las listas definidas en la clase modelo.
Ej de class Dedu, método ListarModulos que retorna una Lista de strings:

public List<string> ListarModulos()
{   return new List<string> { "Gestión de Cursos", "Estadísticas", "Soporte", "Administración" };   }

Ej de class UA (unidad académica) método ListarModulos que retorna la lista de strings.
public List<string> ListarModulos()
{   return new List<string> { "Gestión de Cursos", "Estadísticas" };    }

y luego en usuarioController, creamos la lista de usuarios, y llamamos a sus respectivos métodos de ListarModulos para ver los permisos, pero la particularidad es que en este caso, podemos agarrarnos de las que implementan dicha interfaz por lo que la definición de la lista sería algo como:private List<IUsuarioModulo> usuarios = new List<IusuarioModulo>();*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo un controlador, el cual precarga un usuario de cada clase: Dedu, UA, Estudiante.
            UsuarioController controller = new ();

            Console.WriteLine("A continuacion se listarán los modulos a los que accede cada usuario. Presione cualquier tecla...");
            Console.ReadKey();
            controller.ListarTodo();

        }
    }
}
