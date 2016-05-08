using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using biz.dfch.CS.Utilities.Testing;

namespace ConsoleApplication1.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void DividingTwoNumberReturnsCorrectResult()
        {
            // Arrange
            var dividend = 4;
            var divisor = 2;
            var expectedResult = 2;

            var calc = new Calculator();

            // Act
            var result = calc.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DividingTwoLargeNumberReturnsCorrectResult()
        {
            // Arrange
            var dividend = -1000;
            var divisor = 1;
            var expectedResult = -1000;

            var calc = new Calculator();

            // Act
            var result = calc.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectContractFailure]
        public void DividingByZeroThrowsException()
        {
            // Arrange
            var dividend = 4;
            var divisor = 0;

            var calc = new Calculator();

            // Act
            calc.Divide(dividend, divisor);

            // Assert
            // N/A
        }
    }
}
