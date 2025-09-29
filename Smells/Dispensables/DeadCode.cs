namespace CodeSmells.Smells.Dispensables;

/// <summary>
/// A variable, parameter, field, method or class is no longer used (usually because it’s obsolete).
/// </summary>
public class DeadCode
{
    public void OldMethod() { }

    public int NotUsed { get; set; }
}