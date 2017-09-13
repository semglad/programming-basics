using System;

namespace loops10
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a new instance rnd of object Random. Also define a double to hold the random result
            Random rnd = new Random();
            double a = 0;

            // Loop through the number user input
            for (int x = 1; x <= 13; x++)
            {

                // Draw a random number between 0 and 1
                a = rnd.NextDouble();

                // If the random number is between 0 and 0.4...
                if (a <= 0.4)
                {

                    // Print out a result for a home win
                    Console.Write("{0}. 1\n", x);

                }
                else if ((a > 0.4) & (a < 0.6)) // If the random number is between 0.4 and 0.6...
                {

                    // Print out a result for a draw
                    Console.Write("{0}. X\n", x);

                }
                else
                {

                    // Print out a result for an away win
                    Console.Write("{0}. 2\n", x);

                }

            }

             // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
