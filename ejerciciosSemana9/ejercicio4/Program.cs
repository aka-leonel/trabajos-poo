namespace ejercicio4
{
    /*4) Nos encontramos trabajando en el  Museo Argentino de Ciencias Naturales "Bernardino Rivadavia" y nos solicitaron un desarrollo para almacenar el sonido de diversos animales.
Ayuda: Deberíamos tener en el Main un arreglo de animales y ejecutar un método que tengan todos en común para escuchar los diversos sonidos catalogados por los científicos.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] listaAnimales = new Animal[5];

            listaAnimales[0] = new("Perro");
            listaAnimales[1] = new("Gato");
            listaAnimales[2] = new("Caballo");
            listaAnimales[3] = new("Gallina");
            listaAnimales[4] = new("Vaca");

            foreach (var i in listaAnimales) {
                i.EmitirSonido();
            }
        }
    }
}
