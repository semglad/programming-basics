using System;

namespace loops8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance rnd of object Random.
            Random rnd = new Random();

            // Loop through 4 lines
            for (int i = 1; i <= 4; i++)
            {
                // Print out the row number
                Console.Write("Row {0}: ", i);

                // Loop through 5 lots per line
                for (int f = 1; f <= 5; f++)
                {
                    // If it's not the final lot of the line...
                    if (f != 5)
                    {
                        // Print out a random number trailed by a comma and a space
                        Console.Write("{0}\t", rnd.Next(50));
                    } else
                    {
                        // Print out a random number trailed by a newline
                        Console.Write("{0}\n", rnd.Next(50));
                    }
                }
            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
