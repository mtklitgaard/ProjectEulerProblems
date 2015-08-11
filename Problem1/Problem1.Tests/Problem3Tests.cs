using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace Problems.Tests
{
    /*
    The prime factors of 13195 are 5, 7, 13 and 29.

    What is the largest prime factor of the number 600851475143

    */

    public class Problem3Tests
    {
        [Theory]
        [InlineData(10, 5)]
        [InlineData(13195, 29)]
        [InlineData(600851475143, 6857)]
        public void ReturnsCorrectPrimeFactors(long topNumber, long expected)
        {
            var classUnderTest = new Problem3();

            var actual = classUnderTest.CalculatePrimeNumbers(topNumber);

            Assert.Equal(expected,actual);
        }
    }
}