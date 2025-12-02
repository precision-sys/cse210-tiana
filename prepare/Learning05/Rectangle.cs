using System;

class Rectangle :  Shape
{
    private double _width;
    private double _length;

    public Rectangle(string name, string color, double width, double length) : base(name, color)
    {
        _width = width;
        _length = length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}
