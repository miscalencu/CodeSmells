namespace CodeSmells.Smells.Couplers;

/// <summary>
/// Library that doesn't provide needed functionality.
/// </summary>
public class IncompleteLibrary
{
    public void CheckDate()
    {
        var today = DateTime.Now;

        if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}