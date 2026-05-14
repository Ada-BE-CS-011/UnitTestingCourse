using TestNinja.Fundamentals;

namespace UnitTestsFundamentals.UnitTests.DataDrivenTests
{
    public class MyMathUnitTests_DataDriven
    {
        [Theory]
        [TestCustomData]
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
