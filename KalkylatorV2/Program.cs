using System;
using System.Collections.Generic;
using static KalkylatorV2.Förbättringar;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator(); // Skapa en instans av Calculator-klassen

        List<double> numbers = new List<double>(); // Lista för tal
        List<char> operations = new List<char>();  // Lista för operationer

        Console.WriteLine("Välkommen till miniräknaren!");

        // Hämta första talet
        Console.WriteLine("Ange det första talet:");
        double num = Convert.ToDouble(Console.ReadLine());
        numbers.Add(num);

        // Loop för att fortsätta mata in operationer och tal
        while (true)
        {
            // Be användaren välja en operation
            Console.WriteLine("Välj en operation (+, -, *, /, %, ^) eller tryck = för att få resultatet:");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Flytta till nästa rad

            // Kontrollera om användaren tryckte på '=' för att avsluta inmatningen
            if (operation == '=')
            {
                break; // Avsluta loopen om användaren trycker =
            }

            // Lägg till operationen i listan
            operations.Add(operation);

            // Hämta nästa tal och kontrollera att det är giltigt
            Console.WriteLine("Ange nästa tal:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Fel: Ogiltig inmatning. Försök igen.");
                continue; // Skippa resten av loopen om inmatningen är ogiltig
            }
        }

        try
        {
            // Utför beräkningen på hela listan
            double result = calculator.CalculateMultiple(numbers, operations);
            Console.WriteLine($"Resultatet är: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Tryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
