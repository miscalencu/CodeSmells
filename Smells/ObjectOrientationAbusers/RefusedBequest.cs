namespace CodeSmells.Smells.ObjectOrientationAbusers;

/// <summary>
/// A subclass inherits methods/fields it doesn’t need.
/// </summary>
public class Base
{
    public virtual void DoSomething() => Console.WriteLine("Base work");
}

public class Child : Base
{
    public override void DoSomething()
    {
        /* does nothing */
    }
}