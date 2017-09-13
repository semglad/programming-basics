using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for an integer
            Console.WriteLine("Please input an integer:");

            // Store user input to a variable
            var userInput = Console.ReadLine();
            int number;
            int.TryParse(userInput, out number);

            // If user input is less than zero...
            if (number < 0)
            {

                // ...inform user that the number is negative
                Console.WriteLine("Number {0} is negative", number);

 
            } else if (number > 0) // If user input is greater than zero...
            {

                    // ...inform user that the number is positive
                    Console.WriteLine("Number {0} is positive", number);

            }

            // If user input is zero...
            if (number == 0)
            {

                // ...inform user that the number is zero
                Console.WriteLine("Number {0} is zero", number);
                Console.WriteLine("It is neither negative nor positive number");
                Console.WriteLine("It is an even number");
            } else if (number % 2 == 0) // If the remainder of number / 2 is 0...
            {

                    //...inform user that the number is even
                    Console.WriteLine("It is an even number");

            } else {

                    //...inform user that the number is odd
                    Console.WriteLine("It is an odd number");

            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
