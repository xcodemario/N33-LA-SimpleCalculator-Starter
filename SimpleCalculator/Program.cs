using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = GetValidNumber("Enter the first number: ");
                double secondNumber = GetValidNumber("Enter the second number: ");
                string operation = GetValidOperation();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine("Result: " + result);

            } catch (Exception ex)
            {
       
                Console.WriteLine(ex.Message);
            }
        }

        public static double GetValidNumber(string numberMessage)
        {
            double number;
            while (true)
            {
                Console.Write(numberMessage);
                string input = Console.ReadLine();
                try
                {
                    number = InputConverter.ConvertInputToNumeric(input);
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("enter a valide numeric value.");
                }
            }
            return number;
        }
        public static string GetValidOperation()
        {
            while (true)
            {
                Console.Write("Enter the operation (+, -, *, /,^, plus, minus, times, divide, exponent): ");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                    case "plus":
                        return "+";
                    case "-":
                    case "minus":
                        return "-";
                    case "*":
                    case "times":
                        return "*";
                    case "/":
                    case "divide":
                        return "/";
                    case "^":
                    case "exponent":
                        default:
                        Console.WriteLine("enter a valide operation");
                        break;
                }
            }
        }
    }
}

