using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorTDDKata
{
    [TestClass]
    public class StringCalculatorUnitTesting
    {
        Calculator calculator;

        [TestMethod]
        public void GivenSingleCharString()
        {
            calculator = new Calculator();
            var calculationResult = calculator.CalculateStringNumbers("1");
            Assert.AreEqual(1, calculationResult);
        }

        [TestMethod]
        public void GivenStringWith2Numbers()
        {
            calculator = new Calculator();
            var calculationResult = calculator.CalculateStringNumbers("1,2");
            Assert.AreEqual(2, calculationResult);
        }

        [TestMethod]
        public void GivenStringWith3Numbers()
        {
            calculator = new Calculator();
            var calculatedResult = calculator.CalculateStringNumbers("1,2,3");
            Assert.AreEqual(6, calculatedResult);
        }

        [TestMethod]
        public void GivenAlphaNumbersAreIgnored()
        {
            calculator = new Calculator();
            var calculatedResult = calculator.CalculateStringNumbers("1,2,3,Four");
            Assert.AreEqual(6, calculatedResult);
        }
    }

    public class Calculator
    {
        public double CalculateStringNumbers(string value)
        {
            char[] delimiters = { ',' };
            var numbers = value.Split(delimiters);

            double calculatedValue = Convert.ToDouble(numbers[0]);
            double parsedVal;

            for (int i = 0; i != numbers.Length; i++)
            {
                if (double.TryParse(numbers[i], out parsedVal))
                {
                    calculatedValue *= Convert.ToDouble(numbers[i]);
                }
            }

            return calculatedValue;
        }
    }
}