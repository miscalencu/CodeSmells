namespace CodeSmells.Smells.Bloaters;

/// <summary>
/// Primitive Obsession is when you use primitive data types (int, string, bool, etc.) to represent
/// domain concepts instead of creating small objects for them.
/// </summary>
public class OrderService
{
    public void CreateOrder(
        string customerId, string productId, int quantity,
        string currency, decimal amount, string email,
        string phoneNumber, int orderStatus)
    {
        // Validate email format
        if (!email.Contains("@") || !email.Contains("."))
            throw new ArgumentException("Invalid email");

        // Validate phone number (assuming US format)
        if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            throw new ArgumentException("Invalid phone number");

        // Validate currency
        if (currency != "USD" && currency != "EUR" && currency != "GBP")
            throw new ArgumentException("Unsupported currency");

        // Validate order status (0=Pending, 1=Confirmed, 2=Shipped, 3=Delivered)
        if (orderStatus < 0 || orderStatus > 3)
            throw new ArgumentException("Invalid order status");

        // Create order logic...
    }

    public void UpdateOrderStatus(string orderId, int newStatus)
    {
        if (newStatus < 0 || newStatus > 3)
            throw new ArgumentException("Invalid order status");

        // Update logic...
    }

    public void SendNotification(string email, string message)
    {
        if (!email.Contains("@") || !email.Contains("."))
            throw new ArgumentException("Invalid email");

        // Send notification...
    }
}