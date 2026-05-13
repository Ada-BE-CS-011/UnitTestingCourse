namespace UnitTestsFundamentals.UnitTests
{
    public class CsvData
    {
        public static IEnumerable<object[]> Data()
        {
            var text = File.ReadAllText("Data.csv");

            var replaced = text
                .Replace("int.MaxValue", int.MaxValue.ToString())
                .Replace("int.MinValue", int.MinValue.ToString());

            var lines = replaced.Split(Environment.NewLine);
            foreach (var item in lines)
                yield return item.Split(',');
        }
    }
}
