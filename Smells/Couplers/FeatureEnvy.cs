namespace CodeSmells.Smells.Couplers
{
    public class OrderPrinter
    {
        public void Print(Order order)
        {
            Console.WriteLine(order.CustomerName + order.Amount + order.Date);
        }
    }

    public record Order(string CustomerName, decimal Amount, DateTime Date);
}