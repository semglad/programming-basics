using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for an integer
            Console.WriteLine("Please input an integer:");

            // Store user input to a variable
            var userInput = Console.ReadLine();
            int number;
            int.TryParse(userInput, out number);

            // Prompt user for an integer
            Console.WriteLine("Please input another integer:");

            // Store user input to a variable
            userInput = Console.ReadLine();
            int number2;
            int.TryParse(userInput, out number2);

            // Prompt user for an integer
            Console.WriteLine("Please input yet another integer:");

            // Store user input to a variable
            var userInput3 = Console.ReadLine();
            int number3;
            int.TryParse(userInput3, out number3);

            if (number < number2)
            {
                if (number2 < number3)
                    Console.WriteLine("{0}, {1}, {2}", number, number2, number3);
                else
                {
                    if (number < number3)
                    {
                        Console.WriteLine("{0}, {1}, {2}", number, number3, number2);
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", number3, number, number2);
                    }
                }
            }
            else
            {
                if (number < number3)
                {

                    if (number2 < number3)
                    {

                        Console.WriteLine("{0}, {1}, {2}", number2, number, number3);

                    }
                    else
                    {

                        Console.WriteLine("{0}, {1}, {2}", number3, number, number2);

                    }

                }
                else
                {

                    if (number2 < number3)
                    {

                        Console.WriteLine("{0}, {1}, {2}", number2, number3, number);

                    }
                    else
                    {

                        Console.WriteLine("{0}, {1}, {2}", number3, number2, number);

                    }


                }

            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
