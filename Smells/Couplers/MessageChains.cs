namespace CodeSmells.Smells.Couplers
{
    public class AA
    {
        public BB B = new BB();
    }

    public class BB
    {
        public CC C = new CC();
    }

    public class CC
    {
        public void Do()
        { }
    }

    public class Client
    {
        public void Use(AA a)
        {
            a.B.C.Do();
        }
    }
}