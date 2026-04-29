using System;

Console.WriteLine("Simple C# Calculator");
Console.WriteLine("----------------------");

while (true)
{
    Console.WriteLine("\nChoose operation:");
    Console.WriteLine("1. Addition (+)");
    Console.WriteLine("2. Subtraction (-)");
    Console.WriteLine("3. Multiplication (*)");
    Console.WriteLine("4. Division (/)");
    Console.WriteLine("5. Exit");

    Console.Write("Enter choice (1-5): ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 5)
    {
        Console.WriteLine("Exiting calculator...");
        break;
    }

    Console.Write("Enter first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double result = 0;

    switch (choice)
    {
        case 1:
            result = num1 + num2;
            break;

        case 2:
            result = num1 - num2;
            break;

        case 3:
            result = num1 * num2;
            break;

        case 4:
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Error: Division by zero!");
                continue;
            }
            break;

        default:
            Console.WriteLine("Invalid choice!");
            continue;
    }

    Console.WriteLine("Result: " + result);
}