using TestNinja.Fundamentals;
namespace UnitTestsFundamentals.UnitTests
{
    public class MyMathUnitTests_WithMethodMemberData_OtherClass
    {
        [Theory]
        [MemberData(nameof(MemberData_Method_OtherClass.Dados), MemberType = typeof(MemberData_Method_OtherClass))]
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
