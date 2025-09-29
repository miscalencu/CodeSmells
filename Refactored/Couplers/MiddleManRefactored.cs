namespace CodeSmells.Refactored.Couplers;

/// <summary>
/// remove the unnecessary method
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
}

public class PurchaseService()
{
    public void GetLocation()
    {
        var consumer = new Consumer { Location = new Location { City = "Paris" } };
        Console.WriteLine(consumer.Location.City);
    }
}