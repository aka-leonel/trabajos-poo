namespace ejercicio3
{   /*3) Registro de Actividades del Sistema

Se necesita registrar la actividad de diferentes entidades del sistema. Cada entidad (usuario, curso, inscripción) implementa una interfaz IRegistrable con un método ObtenerLog().

Estructura:
Modelos:
Interfaz IRegistrable con string ObtenerLog()
Clases Usuario, Curso, Inscripcion, etc.

Controlador:
Lista de objetos IRegistrable
Generar reporte de logs de actividad*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // se crea un usuario y se realizan inicios y cierres de sesion para ver cómo almacena y luego muestra los Logs.            
            Usuario usuario = new("juancito");
            usuario.IniciarSesion();
            usuario.CerrarSesion();
            usuario.CerrarSesion();
            Console.WriteLine(usuario.ObtenerLog());
            Console.WriteLine("**************");
            
            // se crea un curso, se agregan dos docentes al equipo y se intenta remover uno que no existe. Luego se muestra el Log de usuario..            
            Curso curso = new("Análisis Matemático");
            curso.AgregarDocente("Fernández");
            curso.AgregarDocente("Mohamed");
            curso.RemoverDocente("Gonzalez");
            curso.RemoverDocente("Fernández");
            Console.WriteLine(curso.ObtenerLog());
            Console.WriteLine("**************");

            // se instancia una inscripcion de juancito al curso de matematica.
            Inscripcion inscripcion = new Inscripcion(usuario, curso);
            Console.WriteLine(inscripcion.ObtenerLog());
        }
    }
}
