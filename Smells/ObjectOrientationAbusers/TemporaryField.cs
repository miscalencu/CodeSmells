namespace CodeSmells.Smells.ObjectOrientationAbusers;

/// <summary>
/// An object has fields only used in rare situations.
/// </summary>
public class Report
{
    public string Title { get; set; }
    public string TempChartType { get; set; } // rarely used

    public void PrintSummary()
    {
        if (TempChartType != null) { /* draw chart */ }
    }
}