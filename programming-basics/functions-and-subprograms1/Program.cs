﻿using System;

namespace functions_and_subprograms1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.Write("Montako tahtea haluat jonoon? ");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();

            // Parse user input into integer. If user 
            int.TryParse(userInput, out int number);

            // If user input is a positive integer...
            if (number > 0)
            {

                // Call the function NumberOfStars with the user input as a parameter
                Console.WriteLine("Tassa tahtijonosi: {0}", NumberOfStars(number));

            } else
            {

                // Print out an error message
                Console.WriteLine("Numero {0} ei ole sallittu luku", number);

            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            string NumberOfStars(int starsAsNumber)
            {

                // Declare a string to hold the stars
                string strStars = "";

                // Loop through the times indicated by the user input
                for (int i = 1; i <= starsAsNumber; i++)
                {

                    // Add a star to the string
                    strStars = strStars + "*";

                }

                // Return the star string
                return strStars;

            }

        }

    }
}
