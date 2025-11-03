/*******************************************************************
 * Name: Princess Ellis
 * Date: 11/02/2025
 * Assignment: Week 4 Calculator Project – Exception Handling
 *
 * Description:
 * This program extends the calculator project to include
 * structured exception handling and input validation.
 * It allows the user to:
 *  - Enter two numbers and divide them
 *  - Handle divide-by-zero and invalid input exceptions
 *  - Continue until the user chooses to quit
 *  - Display helpful messages and maintain smooth execution
 *******************************************************************/

using System;

public class Calculator
{
    // Method to perform division
    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return num1 / num2;
    }
}

public class InputHandler
{
    // Safely get a double value from the user with validation
    public double GetValidDouble(string message)
    {
        double value;
        bool valid = false;

        do
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            try
            {
                if (input == null)
                    throw new FormatException("No input provided.");

                value = Convert.ToDouble(input);
                valid = true;
                return value;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too large or too small! Try again.\n");
            }

        } while (!valid);

        return 0; // fallback (never reached)
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        InputHandler input = new InputHandler();
        bool running = true;

        Console.WriteLine("\n===============================");
        Console.WriteLine("Princess Ellis - Week 4 Project");
        Console.WriteLine("Calculator with Exception Handling");
        Console.WriteLine("===============================\n");
        Console.WriteLine("Welcome! This calculator will divide two numbers safely.\n" +
                          "Enter numeric values when prompted. Enter 'Q' anytime to quit.\n");

        while (running)
        {
            try
            {
                Console.WriteLine("\n--- Division Operation ---");

                Console.Write("Would you like to continue (Y/Q)? ");
                string? choice = Console.ReadLine()?.Trim().ToUpper();
                if (choice == "Q")
                    break;

                double num1 = input.GetValidDouble("Enter the first number: ");
                double num2 = input.GetValidDouble("Enter the second number: ");

                try
                {
                    double result = calc.Divide(num1, num2);
                    Console.WriteLine($"\nResult: {num1} / {num2} = {result:F2}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}");
                    Console.WriteLine("Please enter a nonzero divisor.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected error: {ex.Message}");
            }
        }

        Console.WriteLine("\nThank you for using the calculator application!");
        Console.WriteLine("Goodbye, Princess Ellis!\n");
    }
}

