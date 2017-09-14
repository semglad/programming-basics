using System;

namespace strings2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.WriteLine("Kirjoita jotain kivaa:");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();

            // Replace all "e" characters with "@" characters within the user input and print it out
            Console.WriteLine(userInput.Replace("e", "@"));

            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
