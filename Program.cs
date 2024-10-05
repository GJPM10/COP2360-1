using System;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            PerformDivision(input1, input2);
        }

        static void PerformDivision(string num1, string num2)
        {
            try
            {
                // Convert strings to integers
                int number1 = int.Parse(num1);
                int number2 = int.Parse(num2);

                // Perform the division
                int result = number1 / number2;

                // Output the result
                Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
            }
            catch (FormatException)
            {
                // Handle invalid input format
                Console.WriteLine("Error: Please enter valid integer values.");
            }
            catch (DivideByZeroException)
            {
                // Handle division by zero
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                // Handle numbers that are too large or too small for int
                Console.WriteLine("Error: The number entered is too large or too small.");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
