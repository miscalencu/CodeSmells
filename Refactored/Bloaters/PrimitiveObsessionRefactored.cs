namespace CodeSmells.Refactored.Bloaters;

public record CustomerId
{
    public string Value { get; }

    public CustomerId(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Customer ID cannot be empty");
        Value = value;
    }
}

public record Email
{
    public string Value { get; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !IsValidEmail(value))
            throw new ArgumentException("Invalid email format");
        Value = value;
    }

    private static bool IsValidEmail(string email) =>
        email.Contains('@') && email.Contains('.') && email.Length > 5;
}

public record PhoneNumber
{
    public string Value { get; }

    public PhoneNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !IsValidPhoneNumber(value))
            throw new ArgumentException("Invalid phone number");
        Value = value;
    }

    private static bool IsValidPhoneNumber(string phone) =>
        phone.Length == 10 && phone.All(char.IsDigit);
}

public record Money
{
    public decimal Amount { get; }
    public Currency Currency { get; }

    public Money(decimal amount, Currency currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative");
        Amount = amount;
        Currency = currency;
    }

    public Money Add(Money other)
    {
        if (Currency != other.Currency)
            throw new InvalidOperationException("Cannot add different currencies");
        return new Money(Amount + other.Amount, Currency);
    }
}

public enum Currency
{
    USD,
    EUR,
    GBP
}

public enum OrderStatus
{
    Pending = 0,
    Confirmed = 1,
    Shipped = 2,
    Delivered = 3
}

public class OrderService
{
    public void CreateOrder(CustomerId customerId, string productId, int quantity,
                           Money price, Email email, PhoneNumber phoneNumber,
                           OrderStatus orderStatus)
    {
        // No validation needed - the value objects ensure validity!
        // Create order logic...
    }

    public void UpdateOrderStatus(string orderId, OrderStatus newStatus)
    {
        // Type-safe, no validation needed
        // Update logic...
    }

    public void SendNotification(Email email, string message)
    {
        // Email is guaranteed to be valid
        // Send notification...
    }

    public Money CalculateTotal(Money itemPrice, int quantity, Money shippingCost)
    {
        var subtotal = new Money(itemPrice.Amount * quantity, itemPrice.Currency);
        return subtotal.Add(shippingCost);
    }
}