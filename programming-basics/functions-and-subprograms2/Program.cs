using System;

namespace functions_and_subprograms2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.Write("Anna jokin numero (erottele desimaalit pilkulla): ");

            // Store user input to a variable
            string userInput = Console.ReadLine();

            // Parse user input into integer 
            double.TryParse(userInput, out double inputnumber1);

            // Prompt user for input
            Console.Write("Anna jokin toinen numero: ");

            // Store user input to a variable
            userInput = Console.ReadLine();

            // Parse user input into integer. If user 
            double.TryParse(userInput, out double inputnumber2);

            // Call function LesserNumber using user input as parameters
            Console.WriteLine("Antamistasi numeroista {0} oli pienempi", MinNumber(inputnumber1, inputnumber2));

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            double MinNumber(double number1, double number2)
            {
                // Return the lesser number
                return Math.Min(number1, number2);
            }
        }
    }
}
