namespace CodeSmells.Refactored.Bloaters
{
    public record ReportData(string Title, string Author, DateTime Date, string Content, string Footer);

    public class Report
    {
        public void Create(ReportData data)
        {
            Console.WriteLine(data.Title + data.Author + data.Date + data.Content + data.Footer);
        }
    }
}