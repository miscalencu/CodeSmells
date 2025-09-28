namespace Refactored.ObjectOrientationAbusers;

public interface ILogger
{
    void Log(string message);
}

public class FileLoggerRefactored : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[FileLogger] {message}");
    }
}

public class DatabaseLoggerRefactored : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[DatabaseLogger] {message}");
    }
}

public class ApplicationRefactored
{
    private readonly ILogger _logger;

    public ApplicationRefactored(ILogger logger)
    {
        _logger = logger;
    }

    public void Run()
    {
        _logger.Log("Starting application...");
    }
}