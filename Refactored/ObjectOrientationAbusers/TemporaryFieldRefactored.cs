namespace CodeSmells.Refactored.ObjectOrientationAbusers;
public class Report
{
    public string Title { get; set; }

    public void PrintSummary(string chartType = null)
    {
        if (chartType != null) { /* draw chart */ }
    }
}