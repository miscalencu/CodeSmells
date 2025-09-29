namespace CodeSmells.Refactored.Couplers;

public class Order
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal GetTotal() => Price * Quantity;
}

public class InvoicePrinter
{
    public void PrintOrder(Order order)
    {
        Console.WriteLine($"Order total: {order.GetTotal()}");
    }
}