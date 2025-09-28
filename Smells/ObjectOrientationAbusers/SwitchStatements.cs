namespace CodeSmells.Smells.ObjectOrientationAbusers;

/// <summary>
/// Whn you have a complex switch operator or sequence of if statements.
/// </summary>
public class Employee
{
    public string Type
    {
        get;
        set;
    } = "";

    public double GetBonus()
    {
        switch (Type)
        {
            case "Manager":
                return 1000;

            case "Engineer":
                return 500;

            default:
                return 0;
        }
    }
}