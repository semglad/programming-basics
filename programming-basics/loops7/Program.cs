using System;

namespace loops7
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
                for (int f = 1; f <= 10; f++)
                {

                    // ...calculate the product of i and f
                    a = i * f;

                    // Print out the result
                    Console.WriteLine("{0} X {1} = {2}", i, f, a);

                }

                // Add a newline after each distinct value of i
                Console.WriteLine("\n");

            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
