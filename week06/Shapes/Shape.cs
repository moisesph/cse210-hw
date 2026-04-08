using System.Drawing;

public class Shape
{
    private string _color;


    public void setColor(string color)
    {
        _color = color;
    }

    public string getColor()
    {
        return _color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual float GetArea()
    {
        return -1;
    }
}