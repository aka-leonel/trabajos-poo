/*08/04/2025
 Ejercicio 1: 

Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 

Inicializar una clase Persona con atributos nombre, edad y dni.
Crear un constructor sin parámetros que inicialice con valores por defecto.
Inicializar la clase Persona con solo el nombre.
Crear un constructor que reciba todos los atributos.
Crear un método mostrarDatos() que imprima los atributos.

Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).
 */

/*NOTA: en vez de crear una funcion mostrarDatos()
 usé un override sobre la funcion ToString().
*/
namespace semana4Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor sin parametros
            Persona juan = new Persona();

            //constructor que solo recibe nombre
            Persona martin = new Persona("martin");

            //constructor que recibe los tres parámetros
            Persona ariel = new Persona("ariel", 34, "34.456.456");

            //se imprimen los datos de cada instancia
            Console.WriteLine(juan.ToString());
            Console.WriteLine(martin.ToString());
            Console.WriteLine(ariel.ToString());

        }
    }

    class Persona
    {
        public int Id { get; set; } 
        public string Dni { get; set; }
        public string Nombre { get; set; }        
        public int Edad { get; set; }
        //el ID comienza en cero e ira incrementandose
        private static int _nextId = 0;

        public Persona() {
            Console.WriteLine("$Persona created without parameters.");
            Dni = "-1";
            Edad = -1;
            Nombre = "Juan";
            Id = _nextId;
            _nextId ++;
        }

        public Persona(string nombre, int edad, string dni)
        {
            Dni = dni;
            Nombre = nombre;
            Edad = edad;
            Id = _nextId;
            _nextId++;
        }
        public Persona(string nombre)
        {
            Nombre = nombre;
            Dni = "-1";
            Edad = -1;
            Id = _nextId;
            _nextId++;
        }

        public override string ToString() {
            return ($"Nombre: {Nombre} id: {Id} Dni:{Dni} Edad:{Edad}");
        }
    }
}
