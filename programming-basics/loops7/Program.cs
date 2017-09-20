using System;

namespace loops7
{
    class Program
    {
        static void Main(string[] args)
        {

            // With numbers 1 to 10...
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    // ...calculate the product of i and f
                    var a = i * j;

                    // Print out the result
                    Console.WriteLine("{0} X {1} = {2}", i, j, a);
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
