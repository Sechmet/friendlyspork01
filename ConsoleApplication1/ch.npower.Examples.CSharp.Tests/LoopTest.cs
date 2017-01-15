using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ch.npower.Examples.CSharp.Tests
{
    [TestClass]
    public class LoopTest
    {
        [TestMethod]
        public void LoopForRunTest()
        {
            // Arrange
            var sut = new Loop.LoopFor();

            // Act
            var result = sut.Run();

            // Assert
            Assert.AreEqual(Loop.LoopFor.MAX_COUNT, result);

        }
    }
}
