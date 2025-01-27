
using System;

namespace App_For_Enum
{
    // Define an enum called PrimeColor with three primary colors


    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a color
            Console.Write("Enter Color: ");
            string Color = Console.ReadLine();

            // Try to parse the color input into the enum PrimeColor
            if (Enum.TryParse(Color, true, out PrimeColor ValidColor))
            {
                // Use the switch expression to check for valid prime colors
                string Result = ValidColor switch
                {
                    PrimeColor.red => "This is a Prime Color",
                    PrimeColor.blue => "This is  b a Prime Color",
                    PrimeColor.green => "This is a Prime Color",
                    _ => "This is not a Prime Color"
                };

                // Output the result
                Console.WriteLine(Result);
            }
            else
            {
                // If parsing fails, inform the user the input is invalid
                Console.WriteLine("This is not a valid color.");
            }
        }
    }
}