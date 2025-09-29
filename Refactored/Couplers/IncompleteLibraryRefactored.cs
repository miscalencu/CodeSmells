namespace CodeSmells.Refactored.Couplers;

/// <summary>
/// Extension Method instead of 'helper' class
/// </summary>
public static class DateTimeExtensions
{
    public static bool IsWeekend(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}

public class IncompleteLibraryRefactored
{
    public void CheckDate()
    {
        var today = DateTime.Now;

        if (today.IsWeekend())
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}