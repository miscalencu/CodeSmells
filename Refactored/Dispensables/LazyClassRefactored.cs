namespace CodeSmells.Refactored.Dispensables;

public class Order
{
    public decimal Amount { get; set; }

    public decimal GetFinalAmount()
    {
        // Inline the simple behavior
        return Amount * 0.9m;
    }
}
