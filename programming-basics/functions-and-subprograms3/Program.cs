using System;

namespace functions_and_subprograms3
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 0;
            double inputMinNumber = 5;
            double inputMaxNumber = 50;

            a = AskForANumber(inputMinNumber, inputMaxNumber);

            Console.WriteLine("\nKayttaja antoi luvun {0}", a);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            double AskForANumber(double minNumber, double maxNumber)
            {

                double number = 0;

                // Prompt user for input
                Console.Write("Anna luku valilta {0} ja {1}: ", minNumber, maxNumber);

                // Store user input to a variable
                string userInput = Console.ReadLine().ToString();

                // Parse user input into integer
                while ((!double.TryParse(userInput, out number)) | (number < minNumber) | (number > maxNumber))
                {

                    // Prompt user for input
                    Console.Clear();
                    Console.WriteLine("{0} ei ole valilta {1} ja {2}. Yrita edes! ", userInput, minNumber, maxNumber);
                    Console.Write("Anna luku valilta {0} ja {1}: ", minNumber, maxNumber);

                    // Store user input to a variable
                    userInput = Console.ReadLine().ToString();

                    // Parse user input into integer.
                    // double.TryParse(userInput, out number);

                }

                return number;

            }
        }
    }
}
