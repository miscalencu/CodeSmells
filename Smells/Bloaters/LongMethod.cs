namespace CodeSmells.Smells.Bloaters;

/// <summary>
/// A method that tries to do too much, making it hard to read, understand, and maintain.
/// </summary>
public class OrderProcessor
{
    public decimal ProcessOrder(List<OrderItem> items, string customerType, string promoCode)
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Price * item.Quantity;
        }

        if (customerType == "VIP") total *= 0.9m;
        else if (customerType == "Regular") total *= 0.95m;

        if (promoCode == "SAVE10") total *= 0.9m;
        else if (promoCode == "SAVE20") total *= 0.8m;

        decimal tax = total * 0.08m;
        return total + tax;
    }

    public class OrderItem
    {
        public decimal Price { get; internal set; }
        public int Quantity { get; internal set; }
    }
}