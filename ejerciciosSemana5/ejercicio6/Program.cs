/* 6) Crear la clase Persona, con un método que compare la edad de una persona con otra.
(Se deben crear dos objetos de la clase persona, y ejecutar el método compararEdad en persona2,
pasando como parámetro la edad de persona1). */
/* nota: para que resulte el ejercicio mas interesante, el metodo CompararEdad() recibe 
 como parametro un obejo Persona (en  vez de simplemente un INT de la edad). De esta manera se puede  imprimir por pantalla un mensaje con el nombre de la persona.*/
namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona juan = new Persona("juan", 22);
            Persona maria = new Persona("maria", 25);
            maria.CompararEdad(juan);
        }
    }
}
