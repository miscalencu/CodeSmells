namespace CodeSmells.Smells.Dispensables;

/// <summary>
/// A class has only fields and trivial getters/setters, but no real behavior.
/// </summary>
public class Customer
{
    // Data Class: only data, no behavior
    public string Name { get; set; }
    public int LoyaltyPoints { get; set; }
}

public class LoyaltyService
{
    public void AddPoints(Customer customer, int points)
    {
        // Behavior is outside, manipulating Customer's state
        customer.LoyaltyPoints += points;
    }
}