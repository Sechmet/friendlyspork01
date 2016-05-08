using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        [ExpectedException(typeof(System.Exception))]
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
