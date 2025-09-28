namespace CodeSmells.Refactored.ObjectOrientationAbusers;

public class Base
{
    public virtual void DoSomething() => Console.WriteLine("Base work");
}

public class UsefulChild : Base
{
    public override void DoSomething() => Console.WriteLine("Real work");
}

// or
public class NoChild
{
    // no DoSomething method heres
}