using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("plus", number1, number2);
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("minus", number1, number2);
            Assert.AreEqual(-1, result);

        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 0;
            double result = _calculatorEngine.Calculate("divided by", number1, number2);
            Assert.IsTrue(double.IsInfinity(result));
        }
        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("times", number1, number2);
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void ExponentTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("to the power of", number1, number2);
            Assert.AreEqual(8, result);

        }
    }
}
