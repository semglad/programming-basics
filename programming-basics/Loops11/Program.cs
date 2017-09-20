using System;

namespace loops11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance rnd of object Random. Also define integers to hold the single dice throw result and the number of 6's
            Random rnd = new Random();
            int countOfSixes = 0;

            // Loop through 1000 times
            for (int x = 1; x <= 1000; x++)
            {
                // Draw a random number between 1 and 6
                var a = rnd.Next(1,7);

                // If the random number is 6...
                if (a == 6)
                {
                    // ...add one to the value of b which holds the number 6's
                    countOfSixes++;
                }

                Console.WriteLine("{0}. {1}", x, a);
            }

            // Print out the result
            Console.WriteLine("Kuutonen arvottiin {0} kertaa", countOfSixes);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
