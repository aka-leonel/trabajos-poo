/*
 Ejercicio 2: 

Crear una clase Calculadora.
Crear un método sumar(int a, int b) que devuelva una suma.
Crear un método sumar(double a, double b, double c) para sumar tres números.
Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).
 */
namespace semana4ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculadora calculadora = new Calculadora();
            int a=2,b=3, c=4;
            double x=11, y=12, z=13;
            //probando suma
            calculadora.sumar(a,b);

            //probando suma con doubles
            calculadora.sumar(x, y, z);
            //al parecer funciona con integers igualmente
            calculadora.sumar(a,b,c);

            //suma con mensaje
            calculadora.sumar("Sumare 2+3, eso es ", 2, 3);

            //ver si un numero es par
            calculadora.esPar(32);
            calculadora.esPar(3);



        }
    }
    class Calculadora
    {
        public int sumar(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public double sumar(double a, double b, double c) 
        {
            Console.WriteLine(a + b + c);
            return a + b + c;
        }

        public void sumar(string mensaje, int a, int b)
        {
            int c = a + b;
            Console.WriteLine(mensaje+" " + c);
        }

        public bool esPar(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("El número " + a + " es par");
                return true;
            }
            else
            {
                Console.WriteLine("El número " + a + " es impar");
                return false;
            }
        }
    }
}
