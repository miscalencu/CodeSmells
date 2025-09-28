namespace CodeSmells.Refactored.ChangePreventers;

public class Invoice
{
    public decimal Amount { get; set; }
    public decimal Tax { get; set; }
    public decimal Discount { get; set; }

    public string ToCsv() => $"{Amount},{Tax},{Discount}";
    public override string ToString() => $"Amount: {Amount}, Tax: {Tax}, Discount: {Discount}";
}

public class InvoiceRepository
{
    public void Save(Invoice inv)
    {
        // Serialize whole object instead of referencing individual fields
    }
}
