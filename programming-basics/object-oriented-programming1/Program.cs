using System;

namespace CarObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a new instance of the Car class with the default constructor
            Car rotisko = new Car();
            Console.WriteLine(rotisko.ToString());
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            // Show data for the instance
            Console.Clear();
            rotisko.ShowData();
 
            // Clear the console and accelerate by 20 kph and show data
            Console.Clear();
            rotisko.Accelerate(20);
            rotisko.ShowData();

            // Clear the console and decelerate by 10 % and show data
            Console.Clear();
            rotisko.Decelerate();
            rotisko.ShowData();

            // Clear the screen and prompt user for input
            Console.Clear();
            Console.Write("Anna auton merkki: ");

            // Store user input to a variable
            string inputMerkki = Console.ReadLine();

            // Prompt user for input
            Console.Write("Anna auton nopeus kilometreina tunnissa: ");

            // Store user input to a variable
            string userInput = Console.ReadLine();

            // Declare a variable for the speed value
            double number = 0;

            // If user input was not numerical...
            while (!double.TryParse(userInput, out number))
            {

                // Give an error message
                Console.Write("Virhe! Anna nopeus numerona: ");

                // Prompt for a valid value
                userInput = Console.ReadLine();

            }

            // Create a new instance of the Car class with the user-defined parameters
            Car priima = new Car(inputMerkki, "N/A", "Keltainen", number);

            // Show data for the instance
            Console.Clear();
            priima.ShowData();

            // Clear the console
            Console.Clear();

            // Prompt user for input
            Console.Write("Paljonko nopeutta lisataan kilometreina tunnissa: ");

            // Store user input to a variable
            userInput = Console.ReadLine();

            // If user input was not numerical...
            while(!double.TryParse(userInput, out number))
            {

                // Give an error message
                Console.Write("Virhe, anna numero! Paljonko nopeutta lisataan kilometreina tunnissa: ");

                // Prompt for a valid value
                userInput = Console.ReadLine();

            }

            // Clear the console and accelerate by the user-defined value and show data
            Console.Clear();
            priima.Accelerate(number);
            priima.ShowData();

            // Clear the console and decelerate by 10 % and show data
            Console.Clear();
            priima.Decelerate();
            priima.ShowData();
        }
    }
}
