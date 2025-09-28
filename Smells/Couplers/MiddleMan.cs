namespace CodeSmells.Smells.Couplers
{
    public class A
    {
        private B b = new B();

        public void Do() => b.Do();
    }

    public class B
    {
        public void Do() => Console.WriteLine("Work");
    }
}