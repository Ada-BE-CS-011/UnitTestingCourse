namespace UnitTestsFundamentals.UnitTests
{
    public class TheoryDataExample : TheoryData<int, int, int>
    {
        public TheoryDataExample()
        {
            Add(-1, int.MinValue, int.MaxValue);
            Add(1, int.MaxValue, int.MinValue);
            Add(1, 1, 2);
            Add(0, 0, 0);
            Add(-1, 1, 0);
            Add(-6, -4, -10);
        }
    }
}
