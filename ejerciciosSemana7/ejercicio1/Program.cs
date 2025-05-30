namespace ejercicio1
{
    /*Ejercicio N° 1:
Crear una clase padre Persona con el método presentarse() que imprima por consola "Hola, mi nombre es {nombre atributo}".
Luego crear la clase hija Alumno y sobreescribir la clase padre Persona haciendo que ejecuta su funcionalidad inicial y agregar extra "y soy alumno del instituo {instituto atributo}".*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pablo = new Persona("pablo");
            Alumno ariel = new("Ariel", "Escuela Técnica Ernesto Sabato");
            pablo.Presentarse();
            ariel.Presentarse();
        }
    }
}
