﻿using System;

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
            int negativeFlag = 0;

            // Parse user input into integer
            int.TryParse(userInput, out int number);

            if (number < 0)
            {

                negativeFlag = 1;
                number = number * -1;

            }

            // Loop through all the numbers between 1 and user input
            for (int a = 1; a <= number; a++)
            {

                // If the user input was a negative integer...
                if (negativeFlag == 1)
                {

                    // Convert a to its inverse value
                    a = a * -1;

                }

                // Set b to the value of the sum of itself and the number of iterations so far
                b = b + a;

                // If the user input was a negative integer...
                if (negativeFlag == 1)
                {

                    // Convert a back to its absolute value so it doesn't interfere with the loop
                    a = a * -1;

                }

            }

            // Inform user of the result of the calculation
            Console.WriteLine("{0}", b);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}