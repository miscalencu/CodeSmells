public class PdfReportGeneratorRefactored
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating PDF report...");
    }
}

public class AppRefactored
{
    public void Run()
    {
        var generator = new PdfReportGeneratorRefactored();
        generator.GenerateReport();
    }
}