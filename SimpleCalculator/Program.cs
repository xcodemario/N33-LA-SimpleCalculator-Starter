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
                // Normally, we'd log this error to a file.
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
            return "0";
        }
    }
}

