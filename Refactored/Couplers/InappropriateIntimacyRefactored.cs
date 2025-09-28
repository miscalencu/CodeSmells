namespace CodeSmells.Refactored.Couplers
{
    public class ClassA
    {
        private int secret = 42;

        public int GetSecret() => secret;
    }

    public class ClassB
    {
        public void Show(ClassA a)
        {
            Console.WriteLine(a.GetSecret());
        }
    }
}