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

        [Test]
        [TestCase(1, -1, -1, "Function with two roots")]
        [TestCase(1, 0, -1, "Function with two roots")]
        [TestCase(1, 1, -1, "Function with two roots")]
        [Description("Test prove that if first value is positive and third value negative that delta always is higher than 0 and amount of roots is equal to two.")]
        public void CalculateSquareEquation_PositiveFirstValueAndNegativeThirdValue_ValidMessageAboutRoots(double firtsValue, double secondValue, double thirdValue, string expectedMessageText)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            string resultMessage = sec.message;
            Assert.AreEqual(expectedMessageText, resultMessage);
        }

        [Test]
        [TestCase(1, -1, -1, 2)]
        [TestCase(1, 0, -1, 2)]
        [TestCase(1, 1, -1, 2)]
        [Description("Test prove that if first value is positive and third value negative that delta always is higher than 0 and amount of roots is equal to two.")]
        public void CalculateSquareEquation_PositiveFirstValueAndNegativeThirdValue_AmountOfRootsEqualToTwo(double firtsValue, double secondValue, double thirdValue, int expectedAmountOfRoots)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            int resultRootCounter = sec.rootCounter;
            Assert.AreEqual(expectedAmountOfRoots, resultRootCounter);
        }

        [Test]
        [TestCase(1, -1, -1)]
        [TestCase(1, 0, -1)]
        [TestCase(1, 1, -1)]
        [Description("Test prove that if first value is positive and third value negative that delta always is higher than 0 and amount of roots is equal to two.")]
        public void CalculateSquareEquation_PositiveFirstValueAndNegativeThirdValue_DeltaHigherThanZero(double firtsValue, double secondValue, double thirdValue)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            double resultDelta = sec.delta;
            Assert.Greater(resultDelta, 0);
        }

        [Test]
        [TestCase(-1, -1, 1, "Function with two roots")]
        [TestCase(-1, 0, 1, "Function with two roots")]
        [TestCase(-1, 1, 1, "Function with two roots")]
        [Description("Test prove that if first value is positive and third value negative that delta always is higher than 0 and amount of roots is equal to two.")]
        public void CalculateSquareEquation_NegativeFirtsValueAndPositiveThirdValue_ValidMessageAboutRoots(double firtsValue, double secondValue, double thirdValue, string expectedMessageText)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            string resultMessage = sec.message;
            Assert.AreEqual(expectedMessageText, resultMessage);
        }

        [Test]
        [TestCase(-1, -1, 1, 2)]
        [TestCase(-1, 0, 1, 2)]
        [TestCase(-1, 1, 1, 2)]
        [Description("Test prove that if first value is negative and third value is positive that delta always is higher than 0 and amount of roots is equal to two.")]
        public void CalculateSquareEquation_NegativeFirtsValueAndPositiveThirdValue_AmountOfRootsEqualToTwo(double firtsValue, double secondValue, double thirdValue, int expectedRootsAmount)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            int resultRootCounter = sec.rootCounter;
            Assert.AreEqual(expectedRootsAmount, resultRootCounter);
        }

        [Test]
        [TestCase(-1, -1, 1)]
        [TestCase(-1, 0, 1)]
        [TestCase(-1, 1, 1)]
        [Description("Test prove that if first value is negative and third value is positive that delta always is higher than 0 and amount of roots is equal to two.")]
        public void CalculateSquareEquation_NegativeFirtsValueAndPositiveThirdValue_DeltaHigherThanZero(double firtsValue, double secondValue, double thirdValue)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firtsValue, secondValue, thirdValue);
            double resultDelta = sec.delta;
            Assert.Greater(resultDelta, 0);
        }

        [Test]
        [TestCase(1, -2, 1, "Function with one root")]
        [Description("Example that gives oportunity to check that delta is equal to 0 and has one root")]
        public void CalculateSquareEquation_ExampleForDeltaEqualToZero_ValidMessageAboutRoots(double firstValue, double secondValue, double thirdValue, string expectedMessageText)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firstValue, secondValue, thirdValue);
            string resultMessageText = sec.message;
            Assert.AreEqual(expectedMessageText, resultMessageText);
        }

        [Test]
        [TestCase(1, -2, 1, 1)]
        [Description("Example that gives oportunity to check that delta is equal to 0 and has one root")]
        public void CalculateSquareEquation_ExampleForDeltaEqualToZero_AmountOfRootsEqualToOne(double firstValue, double secondValue, double thirdValue, int expectedRootsAmount)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firstValue, secondValue, thirdValue);
            int resultRootCounter = sec.rootCounter;
            Assert.AreEqual(expectedRootsAmount, resultRootCounter);
        }

        [Test]
        [TestCase(1, -2, 1, 0)]
        [Description("Example that gives oportunity to check that delta is equal to 0 and has one root")]
        public void CalculateSquareEquation_ExampleWithDeltaEqualToZero_DeltaEqualToZero(double firstValue, double secondValue, double thirdValue, double expectedDelta)
        {
            SquareEquationCalculator sec = new SquareEquationCalculator();
            sec.CalculateSquareEquation(firstValue, secondValue, thirdValue);
            double resultDelta = sec.delta;
            Assert.AreEqual(expectedDelta, resultDelta);
        }
    } 
}
