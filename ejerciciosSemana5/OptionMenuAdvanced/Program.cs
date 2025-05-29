namespace OptionMenuAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string input = Console.ReadLine();
                running = ProcesInput(input);
            }
        
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Perform Task A");
            Console.WriteLine("2. Perform Task B");
            Console.WriteLine("3. View Information");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice: ");
        }
        static bool ProcesInput(string choice)
        {
            switch (choice)
            {
                case "1":
                    PerformTaskA();
                    return true;
                case "2":
                    PerformTaskB();
                    return true;
                case "3":
                    ViewInformation();
                    return true;
                case "4":
                    Console.WriteLine("Exiting the application.");
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    return true;
            }
        }

        static void PerformTaskA()
        {
            Console.WriteLine("Executing Task A...");
            // Add code for Task A
        }

        static void PerformTaskB()
        {
            Console.WriteLine("Executing Task B...");
            // Add code for Task B
        }

        static void ViewInformation()
        {
            Console.WriteLine("Displaying some information...");
            // Add code to display information
        }
    }
}
