using System;

namespace Autotuning
{

    // Declare a new class
    class Auto
    {
        // Declare class fields
        public string merkki;
        public double nopeus;

        // Define the default constructor
        public Auto()
        {
            
            // Default values for the class fields
            merkki = "Ford";
            nopeus = 80;

        }
    
        // Define a constructor with parameters
        public Auto(string inputmerkki, double inputnopeus)
        {

            // Set class field values according to the values specified
            merkki = inputmerkki;
            nopeus = inputnopeus;

        }

        // Define a method to show the instance field values
        public void NaytaTiedot()
        {

            Console.WriteLine("Merkki: {0}", merkki);
            Console.WriteLine("Nopeus: {0}", nopeus);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }

        // Define a method to increase the field "nopeus" value by the value specified
        public void Kiihdyta(double muutos)
        {

            nopeus = nopeus + muutos;

        }

        // Define a method to decrease the field "nopeus" value by 10 percent
        public void Jarruta()
        {

            nopeus = Math.Round(nopeus * 0.9);

        }

    }
}
