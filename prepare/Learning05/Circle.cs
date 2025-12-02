using System;

class Circle : Shape
{
    private double _radius;
    public Circle(string name, string color, double radius) : base (name, color)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}