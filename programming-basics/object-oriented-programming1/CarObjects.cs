using System;

namespace CarObjects
{

    // Declare a new class
    class Car
    {
        // Declare class fields
        private string Brand { get; }
        private string Model { get; }
        private string Color { get; set; }
        public double Speed { get; set; }

        // Define the default constructor
        public Car()
        {
            // Default values for the class fields
            Brand = "Ford";
            Model = "Fiesta";
            Color = "Sininen";
            Speed = 80;
        }
    
        // Define a constructor with parameters
        public Car(string brand = "", string model = "", string color = "", double speed = 0)
        {
            // Set class field values according to the values specified
            Brand = brand;
            Model = model;
            Color = color;
            Speed = speed;
        }

        // Define a method to show the instance field values
        public void ShowData()
        {
            Console.WriteLine("Merkki: {0}", Brand);
            Console.WriteLine("Malli: {0}", Model);
            Console.WriteLine("Nopeus: {0}", Speed);
            Console.WriteLine("Vari: {0}", Color);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        // Define a method to increase the field "speed" value by the value specified
        public void Accelerate(double muutos)
        {
            Speed = Speed + muutos;
        }

        // Define a method to decrease the field "speed" value by 10 percent
        public void Decelerate()
        {
            Speed = Math.Round(Speed * 0.9);
        }

        public override string ToString()
        {
            return $"Merkki: {Brand}\nMalli: {Model}\nVari: {Color}\nNopeus: {Speed}";
        }
    }
}
