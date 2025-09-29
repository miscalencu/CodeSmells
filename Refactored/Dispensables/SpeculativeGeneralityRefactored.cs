namespace CodeSmells.Refactored.Dispensables;

public abstract class ReportGenerator
{
    public abstract void GenerateReport();
}

public class PdfReportGenerator : ReportGenerator
{
    public override void GenerateReport()
    {
        Console.WriteLine("Generating PDF report...");
    }
}

public class GenerateService
{
    public void Generate()
    {
        var generator = new PdfReportGenerator();
        generator.GenerateReport();
    }
}