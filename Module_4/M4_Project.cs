using System;

class Project
{
    static void Main()
    {
        // Read user input and get two numbers
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            // Convert input to integers
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            // Perform division
            int result = num1 / num2;
            // Display the result
            Console.WriteLine($"Result: {result}");
        }
        // Handle potential exceptions
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Number is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}