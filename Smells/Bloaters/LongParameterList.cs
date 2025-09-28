namespace CodeSmells.Smells.Bloaters;

/// <summary>
/// A method that takes too many parameters (usually 3-4+), making it hard to call, understand, and maintain.
/// </summary>
public class Report
{
    public void Create(string title, string author, DateTime date, string content, string footer)
    {
        Console.WriteLine(title + author + date + content + footer);
    }
}