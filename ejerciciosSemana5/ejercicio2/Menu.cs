using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Menu
    {
        bool running = true;
        public Menu()
        {
            while (running)
            {
                //Console.Clear();
                DisplayMenu();
                string input = Console.ReadLine();
                running = ProcessInput(input);
            }
        }

        static void DisplayMenu()
        {
            //Console.Clear();
            Console.WriteLine("\nCalculadora de area.");
            Console.WriteLine("Elija una figura:");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Salir");
        }
        static bool ProcessInput(string choice)
        {
            switch (choice)
            {
                case "1":
                    //CalcularAreacirculo
                    CalcularAreaCirculo();
                    return true;
                case "2":
                    //calc area cuadrado
                    CalcularAreaCuadrado();
                    return true;
                case "3":
                    //calc area trian
                    CalcularAreaTriangulo();
                    return true;
                case "4":
                    Console.WriteLine("Saliendo del programa.");
                    return false;
                default:
                    Console.WriteLine("Opcion invalida. Intente de nuevo.");
                    return true;
            }
        }
        private static void CalcularAreaCirculo()
        {
            Console.WriteLine("Ingrese el radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());
            Circulo c = new Circulo(radio);
            double area = c.CalcularArea();
            Console.WriteLine($"El area del circulo de radio {radio} es {area} unidades cuadradas");
        }
        private static void CalcularAreaCuadrado()
        {
            Console.WriteLine("Ingrese la longitud de lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(lado);
            double area = cuadrado.CalcularArea();
            Console.WriteLine($"El area del cuadrado de lado {lado} es {area} unidades cuadradas");
        }

        private static void CalcularAreaTriangulo()
        {
            Console.WriteLine("Ingrese la longitud de la base del triangulo: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            double h = double.Parse(Console.ReadLine());
            Triangulo t = new Triangulo(b, h);
            double area = t.CalcularArea();            
            Console.WriteLine($"El area del triángulo es {area} unidades cuadradas");
        }
    }
}