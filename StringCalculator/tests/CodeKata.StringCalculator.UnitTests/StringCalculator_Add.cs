using System;
using Xunit;

namespace CodeKata.StringCalculator.UnitTests
{
    public class StringCalculator_Add
    {
        private StringCalculator _stringCalculator;
        public StringCalculator_Add()
        {
            _stringCalculator = new StringCalculator();
        }

        [Fact]
        public void ReturnsZero_GivenEmptyString()
        {
            var result = _stringCalculator.Add("");
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("8", 8)]
        public void ReturnsNumber_GivenStringWithOneNumber(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,3", 4)]
        [InlineData("8,1", 9)]
        public void ReturnsSum_GivenStringWithTwoCommaSeparatedNumbers(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,3,4,5", 13)]
        [InlineData("8,1,5,3,7", 24)]
        public void ReturnsSum_GivenStringWithUnknownCommaSeparatedNumbers(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n2,8,4,4", 19)]
        public void ReturnsSum_GivenStringWithCommaOrNewLineSeparatedNumbers(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        [InlineData("1\n2,8,4,4", 19)]
        public void ReturnsSum_GivenStringWithCustomDelimiter(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("-1,2", "Negatives not allowed: -1")]
        [InlineData("2,-4,3,-5", "Negatives not allowed: -4,-5")]
        public void Throws_GivenNegativeInput(string numbers, string expectedResult)
        {
            Action action = () => _stringCalculator.Add(numbers);

            var ex = Assert.Throws<Exception>(action);
            Assert.Equal(expectedResult, ex.Message);
        }

        [Theory]
        [InlineData("1001,2", 2)]
        public void ReturnsSum_GivenStringIgnoringValuesOver1000(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }
    }
}
