public class Rectangle : Shape
{
    private string _color;
    private float _length;
    private float _hight;

    public Rectangle(string color, float length, float hight) : base(color)
    {
        _color = color;
        _length = length;
        _hight = hight;
    }

    public override float GetArea()
    {
        return _length * _hight;
    }
}