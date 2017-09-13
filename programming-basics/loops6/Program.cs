using System;

namespace loops6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare a variable to hold the value of the calculation
            double a = 0;

            // With numbers 1 to 10...
            for (int i = 1; i <= 10; i++)
            {

                // ...calculate the square root of each value and round to two decimals
                a = Math.Round(Math.Sqrt(i), 2);

                // Print out the result
                Console.WriteLine("Luvun {0} neliojuuri on {1}", i, a);

            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
