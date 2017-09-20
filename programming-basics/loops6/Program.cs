using System;

namespace loops6
{
    class Program
    {
        static void Main(string[] args)
        {
            // With numbers 1 to 10...
            for (int i = 1; i <= 10; i++)
            {
                // ...calculate the square root of each value and round to two decimals
                var a = Math.Round(Math.Sqrt(i), 2);

                // Print out the result
                Console.WriteLine("Luvun {0} neliojuuri on {1}", i, a);
            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
