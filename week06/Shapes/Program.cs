using System;

class Program
{
    static void Main(string[] args)
    {
        Square squ = new Square("gray", 5);

        Rectangle rec = new Rectangle("purple", 10, 15);

        Circle cir = new Circle("Orange", 5);


        List<Shape> shapes = new List<Shape> { squ, rec, cir };

        foreach (Shape a in shapes)
        {
            Display(a);
        }
    }

    public static void Display(Shape s)
    {
        Console.WriteLine($"Color: {s.getColor()}, Area: {s.GetArea()}");
    }
}