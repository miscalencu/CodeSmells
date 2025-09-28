namespace CodeSmells.Refactored.Couplers
{
    public class AA
    {
        private BB B = new BB();

        public void Do() => B.Do();
    }

    public class BB
    {
        private CC C = new CC();

        public void Do() => C.Do();
    }

    public class CC
    {
        public void Do() => Console.WriteLine("Work");
    }

    public class Client
    {
        public void Use(AA a) => a.Do();
    }
}