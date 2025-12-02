using System;

public abstract class  Shape
{
    private string _name;
    private string _color;
    public Shape(string name, string color)
    {
        _name = name;
        _color = color;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}