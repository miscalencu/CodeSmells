namespace CodeSmells.Smells.Couplers
{
    public class ClassA
    {
        public int secret = 42;
    }

    public class ClassB
    {
        public void Leak(ClassA a)
        {
            Console.WriteLine(a.secret);
        }
    }
}