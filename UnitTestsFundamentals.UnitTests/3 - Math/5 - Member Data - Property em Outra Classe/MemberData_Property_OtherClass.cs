namespace UnitTestsFundamentals.UnitTests
{
    internal class MemberData_Property_OtherClass
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
    }
}
