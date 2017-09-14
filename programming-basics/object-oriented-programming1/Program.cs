using Autotuning;
using System;

namespace AutoTuning
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a new instance of the Auto class with the default constructor
            Auto rotisko = new Auto();

            // Show data for the instance
            rotisko.NaytaTiedot();

            // Clear the console and accelerate by 20 kph and show data
            Console.Clear();
            rotisko.Kiihdyta(20);
            rotisko.NaytaTiedot();

            // Clear the console and decelerate by 10 % and show data
            Console.Clear();
            rotisko.Jarruta();
            rotisko.NaytaTiedot();

            // Clear the screen and prompt user for input
            Console.Clear();
            Console.Write("Anna auton merkki: ");

            // Store user input to a variable
            string inputMerkki = Console.ReadLine().ToString();

            // Prompt user for input
            Console.Write("Anna auton nopeus kilometreina tunnissa: ");

            // Store user input to a variable
            string userInput = Console.ReadLine().ToString();

            // Declare a variable for the speed value
            double number = 0;

            // If user input was not numerical...
            while (!double.TryParse(userInput, out number))
            {

                // Give an error message
                Console.Write("Virhe! Anna nopeus numerona: ");

                // Prompt for a valid value
                userInput = Console.ReadLine().ToString();

            }

            // Create a new instance of the Auto class with the user-defined parameters
            Auto priima = new Auto(inputMerkki, number);

            // Show data for the instance
            Console.Clear();
            priima.NaytaTiedot();

            // Clear the console
            Console.Clear();

            // Prompt user for input
            Console.Write("Paljonko nopeutta lisataan kilometreina tunnissa: ");

            // Store user input to a variable
            userInput = Console.ReadLine().ToString();

            // If user input was not numerical...
            while(!double.TryParse(userInput, out number))
            {

                // Give an error message
                Console.Write("Virhe, anna numero! Paljonko nopeutta lisataan kilometreina tunnissa: ");

                // Prompt for a valid value
                userInput = Console.ReadLine().ToString();

            }

            // Clear the console and accelerate by the user-defined value and show data
            Console.Clear();
            priima.Kiihdyta(number);
            priima.NaytaTiedot();

            // Clear the console and decelerate by 10 % and show data
            Console.Clear();
            priima.Jarruta();
            priima.NaytaTiedot();
        }
    }
}
