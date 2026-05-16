using TestNinja.Fundamentals;

namespace UnitTestsFundamentals.UnitTests
{
    public class MyMathUnitTests_WithPropertyMemberData_OtherClass
    {
        [Theory]
        [MemberData(nameof(MemberData_Property_OtherClass.Dados), MemberType = typeof(MemberData_Property_OtherClass))]
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
