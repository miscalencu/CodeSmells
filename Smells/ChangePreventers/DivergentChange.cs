namespace CodeSmells.Smells.ChangePreventers;

/// <summary>
/// When one class needs to be modified for many different reasons, violating the Single Responsibility Principle.
/// </summary>
public class Document
{
    public void Print() { }

    public void SavePdf() { }

    public void SaveDocx() { }

    public void SaveHtml() { }
}