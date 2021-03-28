using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatingClassTests
    {
        [TestMethod()]
        public void SplitStringTest()
        {
            string expected = "10";

            string actual = CalculatingClass.SplitString("2,5 *   4 ");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateDivisionTest()
        {
            string[] inputString = new string[2] { "8", "2" };

            double expected = 4;

            double actual = CalculatingClass.CalculateDivision(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateMultiplicationTest()
        {
            string[] inputString = new string[2] { "8", "2" };

            double expected = 16;

            double actual = CalculatingClass.CalculateMultiplication(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSubtractionTest()
        {
            string[] inputString = new string[2] { "8", "2" };

            double expected = 6;

            double actual = CalculatingClass.CalculateSubtraction(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateAdditionTest()
        {
            string[] inputString = new string[2] { "8", "2" };

            double expected = 10;

            double actual = CalculatingClass.CalculateAddition(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}