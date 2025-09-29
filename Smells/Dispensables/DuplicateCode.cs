namespace CodeSmells.Smells.Dispensables;

/// <summary>
/// Two code fragments look almost identical.
/// </summary>
public class Rectangle
{
    public double Width;
    public double Height;

    public double GetArea() => Width * Height;
}

public class Square
{
    public double Side;

    public double GetArea() => Side * Side;
}