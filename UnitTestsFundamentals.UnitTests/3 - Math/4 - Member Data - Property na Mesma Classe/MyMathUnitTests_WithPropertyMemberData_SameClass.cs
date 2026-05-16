using TestNinja.Fundamentals;

namespace UnitTestsFundamentals.UnitTests
{
    public class MyMathUnitTests_WithPropertyMemberData_SameClass
    {
        public static IEnumerable<object[]> Dados => 
        [
            [-1, int.MinValue, int.MaxValue],
            [1, int.MaxValue, int.MinValue],
            [1, 1, 2],
            [0, 0, 0],
            [-1, 1, 0],
            [ -6, -4, -10]
        ];

        [Theory]
        [MemberData(nameof(Dados))]
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
