using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till miniräknaren!");
        Console.WriteLine("Ange det första talet:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ange det andra talet:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Välj en operation (+, -, *, /):");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // För att flytta till nästa rad

        double result = 0;
        bool validOperation = true;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Fel: Division med noll är inte tillåtet.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Ogiltig operation. Försök igen.");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine($"Resultatet är: {result}");
        }

        Console.WriteLine("Tryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
