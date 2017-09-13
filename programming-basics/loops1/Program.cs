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

            // Declare variables used in the loop
            int a = 1;
            int b = 1;


            while (a <= number)
            {

                // Set b to the value of the product of itself and the number of iterations so far
                b = b * a;

                // Move a to its next value
                a = a + 1;

            }

            // Inform user of the result of the calculation
            Console.WriteLine("{0}! equals {1}", number, b);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
