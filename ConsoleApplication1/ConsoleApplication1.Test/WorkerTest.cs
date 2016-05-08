using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Linq;

namespace ConsoleApplication1.Test
{
    [TestClass]
    public class WorkerTest
    {
        public string Message = "tralala";
        public int Invocations = 0;
        public char Suffix = '@';

        [TestMethod]
        public void PrintMessageUntilNextMinuteReturnsResultWithCorrectStringEnding()
        {
            // Arrange
            var worker = new Worker();

            // Act
            var result = worker.PrintMessageUntilNextMinute(Message, Invocations);

            // Assert
            Assert.IsTrue(result.EndsWith(Suffix.ToString()));
        }

        [TestMethod]
        public void PrintMessageUntilNextMinuteReturnsResultWithMaximum60Repitions()
        {
            //  Arrange
            var worker = new Worker();

            // Act
            var result = worker.PrintMessageUntilNextMinute(Message, Invocations);

            // Assert
            var countOccurence = result.Count(charPattern => charPattern == Suffix);
            Assert.IsTrue(countOccurence <= 60);
        }
    }
}
