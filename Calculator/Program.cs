using System;

class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        double result = 0;
        string answer;

        Console.WriteLine("Hello, Welcome to the calculator program!");

        Console.WriteLine("Please enter your first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Which operation would you like to perform?");
        Console.WriteLine("Please enter 'a' for addition, 's' for subtraction, 'm' for multiplication, or 'd' for division:");
        answer = Console.ReadLine();

        if (answer == "a")
        {
            result = num1 + num2;
        }
        else if (answer == "s")
        {
            result = num1 - num2;
        }
        else if (answer == "m")
        {
            result = num1 * num2;
        }
        else if (answer == "d")
        {
            if (num2 != 0)
            {
                result = (double)num1 / num2; // Cast to double for decimal result
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operation selected.");
            return;
        }

        Console.WriteLine("The result is: " + result);
        Console.WriteLine("Thank you for using the calculator!");
        Console.ReadKey();
    }
}
