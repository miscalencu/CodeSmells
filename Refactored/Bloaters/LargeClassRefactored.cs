namespace CodeSmells.Refactored.Bloaters;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class CustomerRepository
{
    public void Add(Customer c) { /* insert into DB */ }
    public void Update(Customer c) { /* update DB */ }
}

public class CustomerValidator
{
    public bool ValidateEmail(string email) { /* regex */ return true; }
    public bool ValidateName(string name) { /* length */ return true; }
}

public class NotificationService
{
    public void SendWelcomeEmail(string email) { /* send email */ }
    public void SendPromotionEmail(string email) { /* send promo */ }
}
