namespace CodeSmells.Refactored.Couplers
{
    public class Order
    {
        public string CustomerName
        {
            get;
        }

        public decimal Amount
        {
            get;
        }

        public DateTime Date
        {
            get;
        }

        public Order(string c, decimal a, DateTime d)
        {
            CustomerName = c;
            Amount = a;
            Date = d;
        }

        public void Print() => Console.WriteLine(CustomerName + Amount + Date);
    }
}