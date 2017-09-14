using System;

namespace strings3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare a variable to be used as a counter for "l" character occurrences in the user input
            int counter = 0;

            // Prompt user for input
            Console.WriteLine("Kirjoita jotain kivaa:");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();

            // Loop through the user input character by character
            for (int i = 0; i < userInput.Length; i++)
            {

                // If the current character equals "l"...
                if (userInput[i] == System.Convert.ToChar("l"))
                {

                    // Increment the counter by one
                    counter = counter + 1;

                }

            }

            // Print out the number of "l" characters in the user input
            Console.WriteLine(@"Syotteessa on {0} ""l"" merkkia", counter);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
