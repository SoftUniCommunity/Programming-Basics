using System;

public class XExpression
{
    public static void Main()
    {
        int symbol = Console.Read();

        decimal result = 0;
        char expressionOperator = '+';

        while (!symbol.Equals('='))
        {
            if (symbol.Equals('('))
            {
                decimal innerResult = 0;
                char innerOperator = '+';

                while (true)
                {
                    symbol = Console.Read();

                    if (symbol.Equals(')')) { break; }

                    if (symbol - '0' >= 0 && symbol - '0' <= 9)
                    {
                        int digit = symbol - '0';

                        switch (innerOperator)
                        {
                            case '+':
                                innerResult += digit;
                                break;
                            case '-':
                                innerResult -= digit;
                                break;
                            case '*':
                                innerResult *= digit;
                                break;
                            case '/':
                                innerResult /= digit;
                                break;
                        }
                    }
                    else
                    {
                        innerOperator = (char)symbol;
                    }
                }

                switch (expressionOperator)
                {
                    case '+':
                        result += innerResult;
                        break;
                    case '-':
                        result -= innerResult;
                        break;
                    case '*':
                        result *= innerResult;
                        break;
                    case '/':
                        result /= innerResult;
                        break;
                }
            }
            else if (symbol - '0' >= 0 && symbol - '0' <= 9)
            {
                int digit = symbol - '0';

                switch (expressionOperator)
                {
                    case '+':
                        result += digit;
                        break;
                    case '-':
                        result -= digit;
                        break;
                    case '*':
                        result *= digit;
                        break;
                    case '/':
                        result /= digit;
                        break;
                }
            }
            else if (symbol.Equals('+') ||
                     symbol.Equals('-') ||
                     symbol.Equals('*') ||
                     symbol.Equals('/'))
            {
                expressionOperator = (char)symbol;
            }

            symbol = Console.Read();
        }

        Console.WriteLine($"{result:F2}");
    }
}