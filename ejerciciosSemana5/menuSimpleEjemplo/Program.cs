/*
 Basic Approach

The fundamental idea is to:

Display the options to the user with corresponding numbers or letters.
Get the user's input.
Process the input using a switch statement or if-else conditions to perform the desired action.
Loop to keep the menu active until the user chooses to exit
 */

namespace menuSimpleEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Option one");
                Console.WriteLine("2. Option two");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Selected option 1.");
                        break;
                    case "2":
                        Console.WriteLine("Selected option 2.");
                        break;
                        case "3":
                        Console.WriteLine("Exiting the application.");
                        running = false;
                        break;
                        default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;

                }
            }
            
            }
        }
}
