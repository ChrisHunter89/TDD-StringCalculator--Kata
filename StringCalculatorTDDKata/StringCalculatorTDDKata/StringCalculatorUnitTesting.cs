using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorTDDKata
{
    [TestClass]
    public class StringCalculatorUnitTesting
    {
        [TestMethod]
        public void GivenSingleCharString()
        {
            Calculator calculator = new Calculator();
            var calculationResult = calculator.CalculateStringNumbers("1");
            Assert.AreEqual(calculationResult, 1);
        }

        [TestMethod]
        public void GivenStringWith2Numbers()
        {
            Calculator calculator = new Calculator();
            var calculationResult = calculator.CalculateStringNumbers("1,2");
            Assert.AreEqual(calculationResult, 2);
        }

        [TestMethod]
        public void GivenStringWith3Numbers()
        {
            Calculator calculator = new Calculator();
            var calculatedResult = calculator.CalculateStringNumbers("1,2,Three");
            Assert.AreEqual(calculatedResult, 6);
        }
    }

    public class Calculator
    {
        public double CalculateStringNumbers(string value)
        {
            char[] delimiters = { ',' };
            var numbers = value.Split(delimiters);

            double calculatedValue = Convert.ToDouble(numbers[0]);

            for (int i = 0; i != numbers.Length; i++)
            {
                calculatedValue *= Convert.ToDouble(numbers[i]);
            }

            return calculatedValue;
        }
    }
}