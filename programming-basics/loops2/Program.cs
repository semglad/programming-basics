using System;

namespace loops1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.Write("Please input an integer: ");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();

            // Parse user input into integer. If user 
            int.TryParse(userInput, out int number);

            // Declare variable to hold the result of each iteration
            int b = 0;

            // Loop through all the numbers between 1 and user input
            for (int a = 1; a <= number; a++)
            {

                // Set b to the value of the sum of itself and the number of iterations so far
                b = b + a;

            }

            // Inform user of the result of the calculation
            Console.WriteLine("{0}! equals {1}", number, b);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
