namespace CodeSmells.Refactored.Dispensables;

/// <summary>
/// Behavior inside the class
/// </summary>
public class Customer
{
    public string Name { get; set; }
    public int LoyaltyPoints { get; private set; }

    public void AddPoints(int points)
    {
        LoyaltyPoints += points;
    }
}