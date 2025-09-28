namespace CodeSmells.Refactored.ObjectOrientationAbusers;

public abstract class Employee
{
    public abstract double GetBonus();
}

public class Manager : Employee
{
    public override double GetBonus() => 1000;
}

public class Engineer : Employee
{
    public override double GetBonus() => 500;
}