using System;

namespace strings1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.WriteLine("Kirjoita jotain kivaa:");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();

            // Print out the length of the user input
            Console.WriteLine("\nSyotteessa on {0} merkkia", userInput.Length);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
