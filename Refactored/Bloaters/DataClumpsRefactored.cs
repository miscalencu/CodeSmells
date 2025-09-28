namespace CodeSmells.Refactored.Bloaters;

public class PersonalInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public PersonalInfo(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string zipCode, string country)
    {
        Street = street;
        City = city;
        ZipCode = zipCode;
        Country = country;
    }

    public bool IsValid()
    {
        // Address validation logic
        return !string.IsNullOrWhiteSpace(Street) &&
               !string.IsNullOrWhiteSpace(City) &&
               !string.IsNullOrWhiteSpace(ZipCode) &&
               !string.IsNullOrWhiteSpace(Country);
    }
}

public class CustomerService
{
    public void CreateCustomer(PersonalInfo personalInfo, Address address)
    {
        // Create customer logic
    }

    public void UpdateCustomer(int customerId, PersonalInfo personalInfo, Address address)
    {
        // Update customer logic
    }

    public void SendMail(PersonalInfo personalInfo, Address address)
    {
        // Send mail logic
    }
}