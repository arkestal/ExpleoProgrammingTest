using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DetectAnagram;
using Xunit;

namespace DetectAnagram.Test
{
    public class AnagramMethodTest
    {
        [Fact]
        public void AnagramCheck_ShouldReturnTrue()
        {
            //The expectation of the method is true
            bool expected = true;

            //What the method actually delivers
            bool actual = AnagramMethod.AnagramCheck("PaRis", "sirap");

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AnagramCheck_ShouldReturnFalse()
        {
            bool expected = false;

            bool actual = AnagramMethod.AnagramCheck("Stockholm", "Stokholm");

            Assert.Equal(expected, actual);
        }
    }
}
