namespace CodeSmells.Smells.Couplers;

/// <summary>
/// One class uses the internal fields and methods of another class.
/// </summary>
public class Customer
{
    public string Name { get; set; }
    public decimal DiscountRate { get; set; }
}

public class LoyaltyService
{
    public decimal CalculateDiscount(Customer customer)
    {
        // Inappropriate Intimacy: digging too deeply into Customer's internals
        if (customer.DiscountRate > 0.1m)
        {
            return customer.DiscountRate * 0.9m;
        }
        return customer.DiscountRate;
    }
}