using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            switch (argOperation) {

                case "plus":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "minus":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "divided by":
                    result = argFirstNumber / argSecondNumber;
                    break;

                case "times":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "to the power of":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;
                default:
                    result = 0;
                    break;
                }

                return result;
            }
        }
    }
