using TestNinja.Fundamentals;

namespace UnitTestsFundamentals.UnitTests
{
    public class MyMathUnitTests_WithExternalData
    {
        [Theory]
        [ClassData(typeof(CsvData))]
        public void ShouldReturnSum(int a, int b, int expected)
        {
            // Arrange
            var sut = new MyMath();

            // Act
            var actual = sut.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
