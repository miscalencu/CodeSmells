namespace CodeSmells.Smells.ChangePreventers;

/// <summary>
/// Parallel Inheritance Hierarchy is a classic smell where every time you add a subclass to one hierarchy, you’re forced to add a corresponding subclass in another.
/// </summary>
// Payment Methods
public abstract class PaymentMethod { }
public class CreditCard : PaymentMethod { }
public class PayPal : PaymentMethod { }

// Payment Processors (forced to mirror hierarchy)
public abstract class PaymentProcessor
{
    public abstract void Process(PaymentMethod method);
}

public class CreditCardProcessor : PaymentProcessor
{
    public override void Process(PaymentMethod method) { /* CC logic */ }
}

public class PayPalProcessor : PaymentProcessor
{
    public override void Process(PaymentMethod method) { /* PayPal logic */ }
}
