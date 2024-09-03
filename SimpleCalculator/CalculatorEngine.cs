using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            switch (argOperation) {

                case "+": 
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
            
            
                case "-":
                case "minus":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "/":
                case "divide":
                case "division":
                    result = argFirstNumber / argSecondNumber;
                    break;

                case "*":
                case "multiply":
                case "multiplication":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "power to":
                case "power of":
                case "exponent":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;

            }

            
            return result;
        }
    }
}
