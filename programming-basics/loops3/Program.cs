using System;

namespace loops3
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
            int c = 0;

            // Loop through all the numbers between 1 and user input
            for (int a = 1; a <= number; a++)
            {

                // If a can be divided by two...
                if (a % 2 == 0)
                {
                    // ...add number of iteration so far to the value of b
                    b = b + a;

                }
                else
                {

                    // Else add number of iteration so far to the value of c
                    c = c + a;

                }
                Console.WriteLine("{0}: {1}, {2}", a, b, c);
            }

            // Inform user of the result of the calculation
            Console.WriteLine("Parillisten summa: {0}, parittomien summa: {1}", b, c);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
