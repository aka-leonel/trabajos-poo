namespace ejercicio4
{
    /*4) Definir la clase Empleado, con nombre, apellido, telefono, email, dni y sueldo.
Definir la clase DptoSistemas (para el Departamento de Sistemas) que posea el área en la
que trabaja de Sistemas, si posee titulo relacionado a su trabajo, si posee una computadora laboral a
su cargo y cantidad de gente a cargo.
Definir la clase Programador donde se almacene en que lenguaje de programación trabaja, si
es senior, semisenior o junior y la cantidad de veces que tumbó producción.
Crear un método mostrar información del empleado en la clase Programador donde muestre
toda la información requerida.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //La clase DeptoSistemas hereda de Empleado.
            //Programador hereda de la clase DeptoSistemas.
            // Se crea un programador 'p' y se prueba la funcion ToString();
            Programador p = new Programador("Juan", "Pérez", "4000-8000", 30123456, "jperez@gmail.com", 300.1f, "Testing", false, true, 0, ["Python", "C#"]);
            Console.WriteLine(p);


        }
    }
}
