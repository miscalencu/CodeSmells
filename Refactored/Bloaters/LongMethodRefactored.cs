namespace CodeSmells.Refactored.Bloaters;
public class OrderProcessor
{
    public decimal ProcessOrder(List<OrderItem> items, string customerType, string promoCode)
    {
        decimal subtotal = CalculateSubtotal(items);
        decimal discounted = ApplyCustomerDiscount(subtotal, customerType);
        decimal withPromo = ApplyPromoCode(discounted, promoCode);
        return AddTax(withPromo);
    }

    private decimal CalculateSubtotal(List<OrderItem> items) =>
        items.Sum(item => item.Price * item.Quantity);

    private decimal ApplyCustomerDiscount(decimal amount, string type) => type switch
    {
        "VIP" => amount * 0.9m,
        "Regular" => amount * 0.95m,
        _ => amount
    };

    private decimal ApplyPromoCode(decimal amount, string code) => code switch
    {
        "SAVE10" => amount * 0.9m,
        "SAVE20" => amount * 0.8m,
        _ => amount
    };

    private decimal AddTax(decimal amount) => amount * 1.08m;
}

public class OrderItem
{
    public decimal Price { get; internal set; }
    public int Quantity { get; internal set; }
}