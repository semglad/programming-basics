using System;

namespace conditional_statements5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.WriteLine("Anna ikäsi numeroina:");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();
            int age;
            double discountPercent = 0;
            int.TryParse(userInput, out age);
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
                Console.WriteLine("Oletko opiskelija (k/e)?");

               // Store user input to a variable
               userInput = Console.ReadKey().ToString();

                if (userInput == "k")
                {

                    discountPercent = 0.45;
                    studentFlag = 1;

                }

                // Prompt user for input (k/e)
                Console.WriteLine("Oletko varusmies (k/e)?");

                // Store user input to a variable
                userInput = Console.ReadKey().ToString();

                if (userInput == "k")
                {

                    discountPercent = 0.50;

                }

                // Prompt user for input (k/e)
                Console.WriteLine("Oletko Mtk:n jäsen (k/e)?");

                // Store user input to a variable
                userInput = Console.ReadKey().ToString();

                if (userInput == "k")
                {

                    if (studentFlag == 1)
                    {

                        discountPercent = 0.45 * 0.15;

                    } else
                    {

                        discountPercent = 0.15;

                    }

                }



            }

            price = initialPrice - (initialPrice * discountPercent);
            Console.WriteLine("Hinta on {0} euroa", price);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
