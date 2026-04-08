public class Square : Shape
{
    private string _color;
    private float _side;

    public Square(string color, float side) : base(color)
    {
        _color = color;
        _side = side;

    }

    public override float GetArea()
    {
        return _side * _side;
    }

}