namespace UnitTestsFundamentals.UnitTests
{
    internal class MemberData_Method_OtherClass
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
    }
}
