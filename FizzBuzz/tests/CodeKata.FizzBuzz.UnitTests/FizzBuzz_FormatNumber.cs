using Xunit;

namespace CodeKata.FizzBuzz.UnitTests
{
    public class FizzBuzz_FormatNumber
    {
        private FizzBuzz _fizzBuzz;

        public FizzBuzz_FormatNumber()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        public void ReturnCorrectResult_GivenInput(int input, string expectedResult)
        {
            var result = _fizzBuzz.FormatNumber(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Return1_Given1()
        {
            var result = _fizzBuzz.FormatNumber(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void Return2_Given2()
        {
            var result = _fizzBuzz.FormatNumber(2);

            Assert.Equal("2", result);
        }

        [Fact]
        public void ReturnFizz_Given3()
        {
            var result = _fizzBuzz.FormatNumber(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ReturnFizz_Given5()
        {
            var result = _fizzBuzz.FormatNumber(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ReturnFizz_Given15()
        {
            var result = _fizzBuzz.FormatNumber(15);

            Assert.Equal("FizzBuzz", result);
        }
    }
}
