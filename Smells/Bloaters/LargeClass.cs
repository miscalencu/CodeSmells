namespace CodeSmells.Smells.Bloaters;

/// <summary>
/// A class that has grown too big and handles too many responsibilities,
/// making it hard to understand, test, and maintain.
/// </summary>
public class CustomerManager
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Customer CRUD
    public void AddCustomer() { /* insert into DB */ }
    public void UpdateCustomer() { /* update DB */ }
    public void DeleteCustomer() { /* delete from DB */ }

    // Validation
    public bool ValidateEmail() { /* regex check */ return true; }
    public bool ValidateName() { /* length check */ return true; }

    // Notifications
    public void SendWelcomeEmail() { /* send email */ }
    public void SendPromotionEmail() { /* send promo */ }

    // Reports
    public string GetPurchaseHistory() { return "history..."; }
    public decimal GetTotalSpent() { return 100m; }

    // Logging
    public void LogInfo(string msg) { /* write info log */ }
    public void LogError(string msg) { /* write error log */ }
}
