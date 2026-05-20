using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class CalculatorUI
        {
            public void Run()
            {
                Console.WriteLine("--- Basic Calculator ---");

                double number1 = ReadValidDouble("Enter first number: ");
                double number2 = ReadValidDouble("Enter second number: ");
                char op = ReadValidOperator();

                double result = 0;
                bool isValidOperation = true;

                switch (op)
                {
                    case '+':
                        result = BasicCalculator.Add(number1, number2);
                        break;
                    case '-':
                        result = BasicCalculator.Subtract(number1, number2);
                        break;
                    case '*':
                        result = BasicCalculator.Multiply(number1, number2);
                        break;
                    case '/':
                        result = BasicCalculator.Divide(number1, number2);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            isValidOperation = false;
                        }
                        break;
                }

                if (isValidOperation)
                {
                    Console.WriteLine($"Result: {number1} {op} {number2} = {result}");
                }
            }

            private double ReadValidDouble(string message)
            {
                while (true)
                {
                    Console.Write(message);
                    if (double.TryParse(Console.ReadLine(), out double value))
                    {
                        return value;
                    }
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }

            private char ReadValidOperator()
            {
                while (true)
                {
                    Console.Write("Enter an operation (+, -, *, /): ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input) && input.Length == 1)
                    {
                        char op = input[0];
                        if (op == '+' || op == '-' || op == '*' || op == '/')
                        {
                            return op;
                        }
                    }
                    Console.WriteLine("Invalid operator! Choose from (+, -, *, /).");
                }
            }
        }
    }


