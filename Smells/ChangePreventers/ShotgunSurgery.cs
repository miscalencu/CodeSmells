namespace CodeSmells.Smells.ChangePreventers;

/// <summary>
/// When making one conceptual change requires modifying many different classes scattered throughout the codebase.
/// </summary>

// Bad - Adding tax calculation requires changes in many classes
public class Invoice
{
    public decimal Amount { get; set; }
    public decimal Tax { get; set; }

    // public decimal Discount { get; set; }
}

public class InvoicePrinter
{
    public void Print(Invoice inv)
    {
        Console.WriteLine($"Amount: {inv.Amount}");
        Console.WriteLine($"Tax: {inv.Tax}");
    }
}

public class InvoiceRepository
{
    public void Save(Invoice inv)
    {
        // Save Amount and Tax into DB
    }
}

public class InvoiceExporter
{
    public string ExportCsv(Invoice inv)
    {
        return $"{inv.Amount},{inv.Tax}";
    }
}
