using System.Collections;

namespace UnitTestsFundamentals.UnitTests
{
    public class ClassDataExample : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { -1, int.MinValue, int.MaxValue };
            yield return new object[] { 1, int.MaxValue, int.MinValue };
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 0, 0, 0 };
            yield return new object[] { -1, 1, 0 };
            yield return new object[] { -6, -4, -10 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
