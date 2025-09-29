namespace CodeSmells.Smells.Dispensables;

// An abstract base class, even though we only have one implementation.
// The "generalization" is speculative, not real.
public abstract class ReportGenerator
{
    public abstract void GenerateReport(string format = "PDF");

    // Added "just in case" we need async in future
    public virtual Task GenerateReportAsync(string format = "PDF")
    {
        throw new NotImplementedException(); // nobody uses this
    }
}

public class PdfReportGenerator : ReportGenerator
{
    public override void GenerateReport(string format = "PDF")
    {
        Console.WriteLine("Generating PDF report...");
    }
}

public class GenerateService
{
    public void Generate()
    {
        ReportGenerator generator = new PdfReportGenerator();
        generator.GenerateReport(); // Always sync, always PDF
    }
}