namespace UnitTestsFundamentals.UnitTests.DataDrivenTests
{
    internal class TestTheoryData : TheoryData<int, int, int>
    {
        // [ClassData(typeof(TestTheoryData))]
        public TestTheoryData()
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
