using System;
using Xunit;

namespace StringCalculator
{
    public class StringCalculatorTests
    {
        private StringCalculator GetStringCalculator()
        {
            return new StringCalculator();
        }

        [Fact]
        public void Add_EmptyString_ShouldReturnZero()
        {
            var sut = GetStringCalculator();
            var result = sut.Add("");
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("10", 10)]
        [InlineData("5000", 5000)]
        public void Add_SingleNumber_ShouldReturnSingleNumber(string numbers, int expected)
        {
            var sut = GetStringCalculator();
            var result = sut.Add(numbers);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("1,1", 2)]
        [InlineData("1,2", 3)]
        public void Add_TwoCommaSeparatedNumbers_ShouldReturnSumOfNumbers(string numbers, int expected)
        {
            var sut = GetStringCalculator();
            var result = sut.Add(numbers);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("1,1,1,1,1", 5)]
        [InlineData("1000,20,5", 1025)]
        public void Add_MultipleCommaSeparatedNumbers_ShouldReturnSumOfNumbers(string numbers, int expected)
        {
            var sut = GetStringCalculator();
            var result = sut.Add(numbers);
            Assert.Equal(expected, result);
        }
    }
}
