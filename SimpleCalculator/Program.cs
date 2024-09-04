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

                Console.WriteLine(firstNumber + operation + secondNumber + " is equal to " + result);
                Console.ReadKey();
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
                    Console.WriteLine("enter a valid numeric value.");
                    
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
                        return "plus";
                        break;
                    case "-":
                    case "minus":
                        return "minus";
                        break;
                    case "*":
                    case "times":
                        return "times";
                        break;
                    case "/":
                    case "divide":
                        return "divided by";
                        break;
                    case "^":
                    case "exponent":
                        return "to the power of";
                        break;
                    default:
                        Console.WriteLine("enter a valide operation");
                        break;
                }
            }
        }
    }
}

