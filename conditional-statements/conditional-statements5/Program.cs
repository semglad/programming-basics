using System;

namespace conditional_statements5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.Write("Kuinka vanha olet (numeroina): ");

            // Store user input to a variable
            string userInput1 = Console.ReadLine().ToString();
            int age;
            double discountPercent = 0;
            double discountPercent2 = 0;
            int.TryParse(userInput1, out age);
            double initialPrice = 16;
            double price;
            int studentFlag = 0;

            if (age < 7)
            {

                discountPercent = 1;

            } else if ((age > 6 & age < 16) | age > 64)
            {

                discountPercent = 0.5;

            } else
            {

               // Prompt user for input (k/e)
                Console.Write("\nOletko opiskelija (k/e)? ");

               // Store user input to a variable
               var userInput = Console.ReadKey();

                if (userInput.Key == ConsoleKey.K)
                {

                    discountPercent = 0.45;
                    studentFlag = 1;

                }

                // Prompt user for input (k/e)
                Console.Write("\nOletko varusmies (k/e)? ");

                // Store user input to a variable
                userInput = Console.ReadKey();

                if (userInput.Key == ConsoleKey.K)
                {

                    discountPercent = 0.50;

                }

                // Prompt user for input (k/e)
                Console.Write("\nOletko Mtk:n jasen (k/e)? ");

                // Store user input to a variable
                userInput = Console.ReadKey();

                if (userInput.Key == ConsoleKey.K)
                {

                    if (studentFlag == 1)
                    {

                        discountPercent = 0.45;
                        discountPercent2 = 0.15;
                    } else
                    {

                        discountPercent = 0.15;

                    }

                }



            }

            price = initialPrice - (initialPrice * discountPercent);
            price = price - (price * discountPercent2);
            Console.WriteLine("\n\nHinta on {0} euroa", price);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
