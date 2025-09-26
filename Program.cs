using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");

            double first = ReadDouble("Enter the first number: ");
            double second = ReadDouble("Enter the second number: ");

            Console.WriteLine($"\nSum:        {first} + {second} = {Calculator.Add(first, second)}");
            Console.WriteLine($"Product:    {first} * {second} = {Calculator.Multiply(first, second)}");

            try
            {
                Console.WriteLine($"Quotient:   {first} / {second} = {Calculator.Divide(first, second)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Quotient:   Error — cannot divide by zero.");
            }

            Console.WriteLine($"Difference: {first} - {second} = {Calculator.Subtract(first, second)}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Helper method to read doubles with validation
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double value))
                    return value;

                Console.WriteLine("Invalid input. Please enter a valid number (e.g., 12 or 3.14).");
            }
        }
    }
}
