using System.Reflection;
using Xunit.Sdk;

namespace UnitTestsFundamentals.UnitTests.DataDrivenTests
{
    public class TestCustomData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
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
