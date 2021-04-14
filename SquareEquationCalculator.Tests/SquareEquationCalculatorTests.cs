using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace SquareEquation
{
    [TestFixture]
    [Author("michal.domaradzki@student.wsb.edu.pl")]
    [Category("Math - Square equation")]
    public class SquareEquationCalculatorTests
    {
        [Test]
        [TestCase(0, 0, 0, "Exception: Divided by 0")]
        [TestCase(0, 1, 1, "Exception: Divided by 0")]
        [TestCase(0, -1, -1, "Exception: Divided by 0")]
        [TestCase(0, 1, -1, "Exception: Divided by 0")]
        [TestCase(0, -1, 1, "Exception: Divided by 0")]
        [Description("Test prove that if first value is equal to zero that denominator is equal to 0 and that generate exception message.")]
        public void CalculateSquareEquation_FirstValueEqualZero_MessageAboutException(double firtsValue, double secondValue, double thirdValue, string expectedMessageText)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            string resultMessage = sec.message;
            Assert.AreEqual(expectedMessageText, resultMessage);
        }

        [Test]
        [TestCase(0, 0, 0, 0)]
        [TestCase(0, 1, 1, 0)]
        [TestCase(0, -1, -1, 0)]
        [TestCase(0, 1, -1, 0)]
        [TestCase(0, -1, 1, 0)]
        [Description("Test prove that if first value is equal to zero that denominator is equal to 0 and that generate exception message.")]
        public void CalculateSquareEquation_FirstValueEqualZero_DenominatorEqualToZero(double firtsValue, double secondValue, double thirdValue, double expectedDenominatorValue)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            double resultMessage = sec.denominator;
            Assert.AreEqual(expectedDenominatorValue, resultMessage);
        }
    } 
}
