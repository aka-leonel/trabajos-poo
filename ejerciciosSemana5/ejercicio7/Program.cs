/* 7) Definir la clase Tren y su hija, Vagón. Se deben crear los 
 * métodos vagonLleno, ascelerar(int velocidad) y frenar. */

/* notas: 
 * En principio se pensó que el metodo VagonLleno retornase un boolneano, pero
 * para simplificar el debuggeo se declaró void e imprime por pantalla si el vagón
 esta lleno o no.*/
namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vagón v1 = new Vagón();
            v1.Acelerar(30);
            v1.Frenar();
            v1.SubirPasajeros(50);
            v1.SubirPasajeros(50);
        }
    }
}
