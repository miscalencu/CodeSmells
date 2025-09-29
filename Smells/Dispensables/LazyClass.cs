namespace CodeSmells.Smells.Dispensables;

/// <summary>
/// A class does too little — it doesn’t justify its existence.
/// </summary>
public class DiscountCalculator
{
    // Lazy Class: only one trivial method
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.9m; // always the same simple rule
    }
}

public class Order
{
    public decimal Amount { get; set; }

    public decimal GetFinalAmount()
    {
        var calc = new DiscountCalculator();
        return calc.ApplyDiscount(Amount);
    }
}