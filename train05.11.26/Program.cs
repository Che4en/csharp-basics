var first = new Rectangle(3,3);
var second = new Rectangle(2,5);

Console.WriteLine(first.GetArea());
Console.WriteLine(second.GetArea());
Console.WriteLine(first.GetPerimeter());
Console.WriteLine(second.GetPerimeter());
Console.WriteLine(first.IsSquare());
Console.WriteLine(second.IsSquare());
first.Scale(2);
Console.WriteLine(first.GetArea());
Console.WriteLine(first.IsBiggerThan(second));

class Rectangle(int width, int height)
{
    private int Width { get; set; } = width;
    private int Height { get; set; } = height;

    public int GetArea()
    {
        return Width * Height;
    }

    public int GetPerimeter()
    {
        return (2*(Width + Height));
    }
    
    
    public bool IsSquare()
    {
        return Width == Height;
    }

    public void Scale(int factor)
    {
        Width *= factor;
        Height *= factor;
    }

    public bool IsBiggerThan(Rectangle other)
    {
        return GetArea() > other.GetArea();
    }

}
