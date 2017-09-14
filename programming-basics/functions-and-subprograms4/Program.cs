using System;

namespace functions_and_subprograms4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int positionOfGreatest = 0;
            string strNumbers = "";
            
            a = GreatestOfTen(out strNumbers, out positionOfGreatest);

            Console.WriteLine("\nSyottamasi lukusarja oli {0}", strNumbers);
            Console.WriteLine("\nSuurin syottamasi luku {0} oli {1}. luku sarjassa", a, positionOfGreatest);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            int GreatestOfTen(out string strNumbers2, out int positionOfGreatest2)
            {

                int number = 0, b = 0;
                strNumbers2 = "";
                positionOfGreatest2 = 0;

                Console.WriteLine("Syota kymmenen lukua");

                for (int i = 1; i <= 10; i++)
                {

                    // Prompt user for input
                    Console.Write("{0}. ", i);

                    // Store user input to a variable
                    string userInput = Console.ReadLine().ToString();

                    // Parse user input into integer
                    while ((!int.TryParse(userInput, out number)) | (number < 0))
                    {

                        // Prompt user for input
                        Console.WriteLine("Vaara syote, syota positiivinen luku!");
                        Console.Write("{0}. ", i);
                        
                        // Store user input to a variable
                        userInput = Console.ReadLine().ToString();

                    }

                    if (i > 1)
                    {

                        strNumbers2 = strNumbers2 + ", " + number;

                    } else
                    {

                        strNumbers2 = "" + number;

                    }


                    if (b < number)
                    {

                        b = number;
                        positionOfGreatest2 = i;

                    }


                }

                return b;

            }

        }
    }
}
