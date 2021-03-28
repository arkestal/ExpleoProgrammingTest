using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetectAnagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectAnagram.Tests
{
    [TestClass()]
    public class AnagramMethodTests
    {
        [TestMethod()]
        public void AnagramCheckTrueTest()
        {
            //The expectation of the method is true
            bool expected = true;

            //What the method actually delivers
            bool actual = AnagramMethod.AnagramCheck("PaRis", "sirap");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AnagramCheckFalseTest()
        {
            bool expected = false;

            bool actual = AnagramMethod.AnagramCheck("Stockholm", "Stokholm");

            Assert.AreEqual(expected, actual);
        }
    }
}