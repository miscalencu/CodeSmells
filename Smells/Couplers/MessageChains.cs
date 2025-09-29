namespace CodeSmells.Smells.Couplers;

/// <summary>
/// In code you see a series of calls resembling $a->b()->c()->d()
/// </summary>
public class Address
{
    public string City { get; set; }
}

public class User
{
    public Address Address { get; set; }
}

public class Shipment
{
    public User User { get; set; }
}

public class ShippingService
{
    public void Ship(Shipment shipment)
    {
        // Message Chain: digging through multiple objects
        string city = shipment.User.Address.City;
        Console.WriteLine($"Shipping to {city}");
    }
}
