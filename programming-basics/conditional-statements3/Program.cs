using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for an integer
            Console.Write("Please input an integer: ");

            string positivity = "default";
            string parity;

            // Store user input to a variable
            var userInput = Console.ReadLine();
            int number;
            int.TryParse(userInput, out number);

            // If user input is less than zero...
            if (number < 0)
            {

                // ...inform user that the number is negative
                positivity = "negative";


            }
            else if (number > 0) // If user input is greater than zero...
            {

                // ...inform user that the number is positive
                positivity = "positive";

            }

            // If user input is zero...
            if (number == 0)
            {

                // ...inform user that the number is zero
                positivity = "neither negative nor positive";
                parity = "even";
            }
            else if (number % 2 == 0) // If the remainder of number / 2 is 0...
            {

                //...inform user that the number is even
                parity = "even";

            }
            else
            {

                //...inform user that the number is odd
                parity = "odd";

            }

            Console.WriteLine("Number is an {1} number. It is {0}.", positivity, parity);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
