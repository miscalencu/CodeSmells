namespace CodeSmells.Refactored.ChangePreventers;

public abstract class PaymentMethod
{
    public abstract void Process();
}

public class CreditCard : PaymentMethod
{
    public override void Process() { /* CC logic */ }
}

public class PayPal : PaymentMethod
{
    public override void Process() { /* PayPal logic */ }
}
