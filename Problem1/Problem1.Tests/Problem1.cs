using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/

namespace Problems.Tests
{
    public class Problem1Tests
    {
        [Theory]
        [InlineData(10,23)]
        [InlineData(1000, 233168)]
        public void GetMultiplesOfThreeAndFive_ReturnsCorrectMultiples(int naturalNumber, int expected)
        {
            var multiplesOfThreeAndFive = new Problem1();
            var actual = multiplesOfThreeAndFive.GetSumOfMultiples(naturalNumber);

            Assert.Equal(expected, actual);
        }
    }
}
