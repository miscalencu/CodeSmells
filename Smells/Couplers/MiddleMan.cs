namespace CodeSmells.Smells.Couplers;

/// <summary>
/// Class delegates all work to another.
/// </summary>
public class Location
{
    public string City { get; set; }
}

public class Consumer
{
    public Location Location { get; set; }
}

public class Purchase
{
    private Consumer _consumer;

    public Purchase(Consumer consumer)
    {
        _consumer = consumer;
    }

    // Middle Man: just forwarding to Customer
    public Location GetAddress() => _consumer.Location;
}

public class PurchaseService()W
{
    public void GetLocation()
    {
        var order = new Purchase(new Consumer { Location = new Location { City = "Paris" } });
        Console.WriteLine(order.GetAddress().City);
    }
}