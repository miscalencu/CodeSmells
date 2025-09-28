namespace CodeSmells.Refactored.ChangePreventers;

public interface ISaveStrategy
{
    void Save();
}

public class PdfSaver : ISaveStrategy // Changes only for PDF saving
{
    public void Save() => Console.WriteLine("PDF");
}

public class DocxSaver : ISaveStrategy // Changes only for Docx saving
{
    public void Save() => Console.WriteLine("DOCX");
}

public class Document
{
    private ISaveStrategy saver;

    public Document(ISaveStrategy saver) => this.saver = saver;

    public void Save() => saver.Save();
}