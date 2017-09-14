using System;

namespace strings4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare a variable to hold the reversed user input
            string userInputPalindrome = "";

            // Prompt user for input
            Console.WriteLine("Kirjoita palindromi (voit kayttaa pilkun ja pisteen lisaksi seuraavia merkkeja:");
            Console.WriteLine("?, !, [valilyonti], ', -, [kaksoispiste]):");

            // Store user input into a variable
            string userInput = Console.ReadLine().ToString();

            // Trim the input of most common special characters and switch to lower case
            string userInputTrimmed = userInput.Replace(",", "");
            userInputTrimmed = userInputTrimmed.Replace(".", "");
            userInputTrimmed = userInputTrimmed.Replace("?", "");
            userInputTrimmed = userInputTrimmed.Replace("!", "");
            userInputTrimmed = userInputTrimmed.Replace(" ", "");
            userInputTrimmed = userInputTrimmed.Replace("\"", "");
            userInputTrimmed = userInputTrimmed.Replace("\'", "");
            userInputTrimmed = userInputTrimmed.Replace(":", "");
            userInputTrimmed = userInputTrimmed.Replace("-", "");
            userInputTrimmed = userInputTrimmed.ToLower();

            // Loop through the user input character by character
            for (int i = 0; i < userInputTrimmed.Length; i++)
            {

                // Append the characters from user input to a variable in reversed order
                userInputPalindrome = userInputPalindrome + userInputTrimmed[userInputTrimmed.Length - i - 1];

            }

            // If the reversed user input equals the initial user input...
            if (userInputPalindrome == userInputTrimmed)
            {

                // ...inform the user that their input is a palindrome
                Console.WriteLine(@"Hienoa! ""{0}"" todellakin on palindromi", userInput);

            } else
            {

                // Else inform the user that their input is not a palindrome
                Console.WriteLine(@"Tuota tuota... ""{0}"" ei valitettavasti ole palindromi", userInput);

            }

            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
