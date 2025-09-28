namespace CodeSmells.Smells.Bloaters;

/// <summary>
/// A data clump is when you see the same group of data items (parameters, fields, or variables)
/// appearing together repeatedly across your codebase.
/// </summary>
public class CustomerService
{
    public void CreateCustomer(string firstName, string lastName, string email,
                              string street, string city, string zipCode, string country)
    {
        // Create customer logic
    }

    public void UpdateCustomer(int customerId, string firstName, string lastName, string email,
                              string street, string city, string zipCode, string country)
    {
        // Update customer logic
    }

    public bool ValidateAddress(string street, string city, string zipCode, string country)
    {
        // Address validation logic
        return true;
    }

    public void SendMail(string firstName, string lastName, string email,
                        string street, string city, string zipCode, string country)
    {
        // Send mail logic
    }
}