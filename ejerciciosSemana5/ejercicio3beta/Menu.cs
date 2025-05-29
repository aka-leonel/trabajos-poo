using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3beta
{
    internal class Menu
    {

        bool running = true;
        public Menu(Cuenta[] cuentasNuevas)
        {
            int i = 0;
            //mientras no se elija salir y halla lugar en cuentas nuevas
            while (running && i < cuentasNuevas.Length)
            {
                //Console.Clear();
                DisplayMenu();
                string input = Console.ReadLine();
                running = ProcessInput(input);
            }
           
        }

        private void DisplayMenu()
        {
            //Console.Clear();
            Console.WriteLine("\n--- Gestor de cuentas ---");
            Console.WriteLine("1. Crear cuenta (mayor de 17 años).");
            Console.WriteLine("2. Crear cuenta menor.");
            Console.WriteLine("3. Crear cuenta estudiante");
            Console.WriteLine("4. Salir");
        }
        static bool ProcessInput(string choice)
        {
            switch (choice)
            {
                case "1":
                    //1. Crear cuenta (mayor de 17 años).

                    return true;
                case "2":
                    //calc area cuadrado
                    
                    return true;
                case "3":
                    //calc area trian


                    return true;
                case "4":
                    Console.WriteLine("Saliendo del programa.");
                    return false;
                default:
                    Console.WriteLine("Opcion invalida. Intente de nuevo.");
                    return true;
            }
        }

       
    }
}
