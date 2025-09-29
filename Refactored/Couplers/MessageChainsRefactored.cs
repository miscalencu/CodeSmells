namespace CodeSmells.Refactored.Couplers;

/// <summary>
/// Tell, Don't Ask: Instead of asking an object for data and then using that data to make decisions, ask the object to perform the action for you.
/// </summary>
public class Address
{
    public string City { get; set; }
}

public class User
{
    public Address Address { get; set; }

    public string GetCity() => Address.City;
}

public class Shipment
{
    public User User { get; set; }

    public string GetShippingCity() => User.GetCity();
}

public class ShippingService
{
    public void Ship(Shipment shipment)
    {
        // No chain — just ask the order
        string city = shipment.GetShippingCity();
        Console.WriteLine($"Shipping to {city}");
    }
}