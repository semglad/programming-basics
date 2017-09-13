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

            // Parse user input into integer. If user 
            int.TryParse(userInput, out int number);

            // Declare a flag to indicate whether user input is negative or positive (negative=1, positive=0, value 0 by default)
            int negativeFlag = 0;

            // If user input is a negative integer...
            if (number < 0)
            {

                // Raise the flag indicating that the user input is a negative integer
                negativeFlag = 1;

                // Convert the user input to its absolute value so it doesn't interfere with the loop
                number = number * -1;

            }

            // Declare variable to hold the result of each iteration
            int b = 0;
            int c = 0;

            // Loop through all the numbers between 1 and user input
            for (int a = 1; a <= number; a++)
            {

                // If the user input was a negative integer...
                if (negativeFlag == 1)
                {

                    // Convert a to its inverse value
                    a = a * -1;

                }

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

                // Convert a back to its absolute value so it doesn't interfere with the loop
                a = a * -1;

            }

            // Inform user of the result of the calculation
            Console.WriteLine("Parillisten summa: {0}, parittomien summa: {1}", b, c);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
