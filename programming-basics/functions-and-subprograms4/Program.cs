using System;

namespace functions_and_subprograms4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the series of integers, greatest integer and position of the greatest integer
            int maxInteger = 0;
            int maxIntegerPosition = 0;
            string strNumbers = "";

            // Call function GreatestOfTen with some dummy parameters
            maxInteger = MaxOfTen(out strNumbers, out maxIntegerPosition);

            // Print out the integers input by the user, the greatest integer and the position of the greatest integer
            Console.WriteLine("\nSyottamasi lukusarja oli {0}", strNumbers);
            Console.WriteLine("\nSuurin syottamasi luku {0} oli {1}. luku sarjassa", maxInteger, maxIntegerPosition);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // GreatestOfTen function is declared with two out parameters in order to return multiple values of multiple
            // types
            int MaxOfTen(out string numbersToPrint, out int maxIntegerPositionToPrint)
            {
                // Declare variables for the current integer, the greatest integer, integer series and the position of
                // the greatest integer
                int number = 0, maxIntegerToPrint = 0;
                numbersToPrint = "";
                maxIntegerPositionToPrint = 0;

                // Inform the user of what they are expected to input
                Console.WriteLine("Syota kymmenen lukua");

                // Loop through 10 times
                for (int i = 1; i <= 10; i++)
                {
                    // Prompt user for input
                    Console.Write("{0}. ", i);

                    // Store user input to a variable
                    string userInput = Console.ReadLine();

                    // Parse user input into integer. If it's not a proper numerical value...
                    while ((!int.TryParse(userInput, out number)) || (number < 0))
                    {
                        // ...display an error message and prompt again user for input
                        Console.WriteLine("Vaara syote, syota positiivinen luku!");
                        Console.Write("{0}. ", i);
                        
                        // Store user input to a variable
                        userInput = Console.ReadLine();
                    }

                    // Append the user input into the string holding the input integers. Integers are preceded by
                    // a comma and a space, except for the very first integer.
                    if (i > 1)
                        numbersToPrint = numbersToPrint + ", " + number;
                    else
                        numbersToPrint = "" + number;

                    // If the value of the current greatest integer is less than the one of the integer input by
                    // the user...
                    if (maxIntegerToPrint < number)
                    {
                        // ...replace the value of the variable with the input and store the current integer position
                        maxIntegerToPrint = number;
                        maxIntegerPositionToPrint = i;
                    }
                }

                // Return the greatest integer
                return maxIntegerToPrint;
            }
        }
    }
}
