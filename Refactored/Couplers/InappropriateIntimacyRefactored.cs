namespace CodeSmells.Refactored.Couplers;
public class Customer
{
    public string Name { get; set; }
    public decimal DiscountRate { get; set; }

    public decimal GetEffectiveDiscount()
    {
        return DiscountRate > 0.1m ? DiscountRate * 0.9m : DiscountRate;
    }
}

public class LoyaltyService
{
    public decimal CalculateDiscount(Customer customer)
    {
        // Just use the Customer's own encapsulated behavior
        return customer.GetEffectiveDiscount();
    }
}
