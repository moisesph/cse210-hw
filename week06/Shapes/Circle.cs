public class Circle : Shape
{

    private string _color;
    private double _radius;
    public const double PI = 3.1415926535897931;

    public Circle(string color, float radius) : base(color)
    {
        _color = color;
        _radius = radius;
    }

    public override float GetArea()
    {
        double result = PI * Math.Pow(_radius, 2);
        return (float)result;
    }
}