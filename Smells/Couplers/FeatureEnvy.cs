namespace CodeSmells.Smells.Couplers;

/// <summary>
/// A method accesses the data of another object more than its own data.
/// </summary>
public class Order
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class InvoicePrinter
{
    public void PrintOrder(Order order)
    {
        // Feature Envy: This class is too interested in Order's data
        decimal total = order.Price * order.Quantity;
        Console.WriteLine($"Order total: {total}");
    }
}