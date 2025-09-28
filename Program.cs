internal class Program
{
    private static void Main()
    {
        var invoice = new CodeSmells.Smells.Bloaters.Invoice(1, "Alice",
            [
                new CodeSmells.Smells.Bloaters.Item("Book", 2, 12.5m),
                new CodeSmells.Smells.Bloaters.Item("Pen", 5, 1.2m)
            ]);

        Console.WriteLine("=== Smelly ===");
        new CodeSmells.Smells.Bloaters.InvoicePrinter().PrintInvoice(invoice);

        Console.WriteLine("\n=== Refactored ===");
        new CodeSmells.Refactored.Bloaters.InvoicePrinter().PrintInvoice(invoice);
    }
}