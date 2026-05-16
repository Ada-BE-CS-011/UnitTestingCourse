using TestNinja.Fundamentals;

namespace UnitTestsFundamentals.UnitTests
{
    public class FizzBuzzUnitTests
    {
        [Theory]
        [InlineData(0, "FizzBuzz")]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(7, "7")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(int.MinValue, "-2147483648")]
        [InlineData(int.MaxValue, "2147483647")]
        public void Teste(int number, string expected)
        {
            var actual = FizzBuzz.GetOutput(number);

            Assert.Equal(expected, actual);
        }
    }
}
