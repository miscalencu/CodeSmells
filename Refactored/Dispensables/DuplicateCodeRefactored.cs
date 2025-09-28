namespace CodeSmells.Refactored.Dispensables
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public override double GetArea() => Width * Height;
    }

    public class Square : Rectangle
    {
        public double Side
        {
            get => Width;
            set
            {
                Width = Height = value;
            }
        }
    }
}