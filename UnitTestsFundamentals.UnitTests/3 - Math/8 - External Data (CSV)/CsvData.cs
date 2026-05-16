using System.Collections;

namespace UnitTestsFundamentals.UnitTests
{
    public class CsvData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var text = File.ReadAllText(@"3 - Math\8 - External Data (CSV)\Data.csv");

            var replaced = text
                .Replace("int.MaxValue", int.MaxValue.ToString())
                .Replace("int.MinValue", int.MinValue.ToString());

            var lines = replaced.Split(Environment.NewLine);
            foreach (var item in lines)
                yield return item.Split(',');
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
