namespace ejercicio1
{
    /*1)  Crear una clase abstracta Figura con un método abstracto CalcularArea(). Crear las clases Cuadrado, Círculo y Triángulo que hereden de Figura e implementen el método abstracto según su operación para calcular el área.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo una instancia de cada objeto.
            Triangulo triangulo = new(2, 3);
            Cuadrado cuadrado = new(4);
            Circulo circulo = new(1);

            //calculo e imprimo por pantalla el resultado
            triangulo.CalcularArea();
            cuadrado.CalcularArea();
            circulo.CalcularArea();
        }
    }
}
