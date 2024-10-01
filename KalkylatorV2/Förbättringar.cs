using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkylatorV2
{
    internal class Förbättringar
    {


public class Calculator
    {
        // Metod för att utföra beräkningen
        public double Calculate(double num1, double num2, char operation)
        {
            double result = 0;

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
                        throw new DivideByZeroException("Fel: Division med noll är inte tillåtet.");
                    }
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    throw new InvalidOperationException("Ogiltig operation.");
            }

            return result;
        }

        // Metod för att beräkna en lista med tal och operationer
        public double CalculateMultiple(List<double> numbers, List<char> operations)
        {
            double result = numbers[0];

            for (int i = 0; i < operations.Count; i++)
            {
                result = Calculate(result, numbers[i + 1], operations[i]);
            }

            return result;
        }
    }

}
}
