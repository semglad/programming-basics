using System;

namespace loops4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.Write("Please input an integer: ");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();

            // Declare variable to hold the result of each iteration and a flag to indicate whether the user input was a negative integer or not
            int b = 0;

            // Parse user input into integer
            int.TryParse(userInput, out int number);

            // Loop through all the numbers between 1 and user input
            for (int a = 1; a <= Math.Abs(number); a++)
            {
                if (number > 0)
                    // Set b to the value of the sum of itself and the number of iterations so far
                    b = b + a;
                else
                    b = b - a;

            }

            // Inform user of the result of the calculation
            Console.WriteLine("{0}", b);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
