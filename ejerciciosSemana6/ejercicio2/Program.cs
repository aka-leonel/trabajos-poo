/*2) Crear la clase Persona con los siguientes atributos:
nombre
private edad
DNI
Método:
MostrarInformación() que imprima por consola los tres atributos.
Crear 3 constructores:
Uno vacío.
Uno que reciba por parametro el nombre y la edad.
Uno que reciba el nombre, la edad y el DNI.
En el Main:
Crear tres objetos de Persona usando los distintos constructores y mostrar los valores de sus
propiedades con el método MostrarInformación().*/
namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new ();
            Persona persona2 = new ("Laura", 32);
            Persona persona3 = new ("Martin", 46, 30123456);

            persona1.MostrarInformacion();
            persona2.MostrarInformacion();
            persona3.MostrarInformacion();
        }
    }
}
