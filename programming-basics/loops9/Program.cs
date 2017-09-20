using System;

namespace loops9
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a new instance rnd of object Random. Also define a string variable to hold the result comment and integers to hold the single coin flip result and the number of occurrences for each result
            Random rnd = new Random();
            string vresult;
            int a = 0, b = 0, c = 0;

            // Prompt user for input
            Console.Write("Montako kertaa haluat heittaa kolikkoa: ");

            // Store user input to a variable
            string userInput = Console.ReadLine();

            // Parse user input into integer. If user 
            int.TryParse(userInput, out int number);

            // Loop through the number user input
            for (int x = 1; x <= number; x++)
            {
                // Draw a random number between 0 and 1
                a = rnd.Next(2);

                // If the random number is 0...
                if (a == 0)
                {
                    // ...add one to the value of b which holds the number of crowns
                    b = b + 1;
                }
                else
                {
                    // ...add one to the value of c which holds the number of tails
                    c = c + 1;
                }
            }

            // If number of heads exceeds the number of tails...
            if (b > c)
            {
                // ...congratulate the user
                vresult = "Onneksi olkoon!";
            } else
            {
                // ...wish the user better luck next time
                vresult = "Parempaa onnea ensi kerralla!";
            }

            // Print out the result
            Console.WriteLine("Kolikkoa heitettiin {0} kertaa. Tuloksena {1} kruunaa ja {2} klaavaa. {3}", number, b, c, vresult);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
