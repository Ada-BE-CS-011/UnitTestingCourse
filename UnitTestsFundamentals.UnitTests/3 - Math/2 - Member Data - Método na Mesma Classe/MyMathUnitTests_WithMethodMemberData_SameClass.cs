using TestNinja.Fundamentals;

namespace UnitTestsFundamentals.UnitTests
{
    public class MyMathUnitTests_WithMethodMemberData_SameClass
    {
        public static IEnumerable<object[]> Dados()
        {
            yield return new object[] { -1, int.MinValue, int.MaxValue };
            yield return new object[] { 1, int.MaxValue, int.MinValue };
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 0, 0, 0 };
            yield return new object[] { -1, 1, 0 };
            yield return new object[] { -6, -4, -10 };
        }

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
