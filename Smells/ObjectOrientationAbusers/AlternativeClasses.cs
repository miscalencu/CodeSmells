namespace Smells.ObjectOrientationAbusers;

/// <summary>
/// Two classes perform identical functions but have different method names.
/// </summary>
public class FileLogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine($"[FileLogger] {message}");
    }
}

public class DatabaseLogger
{
    public void LogMessage(string msg)
    {
        Console.WriteLine($"[DatabaseLogger] {msg}");
    }
}

public class Application
{
    public void Run()
    {
        var fileLogger = new FileLogger();
        fileLogger.WriteLog("Starting application...");

        var dbLogger = new DatabaseLogger();
        dbLogger.LogMessage("Saving to database...");
    }
}