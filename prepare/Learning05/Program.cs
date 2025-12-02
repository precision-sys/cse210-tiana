using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle("First Rectangle", "yellow", 67.0, 124.0);
        Circle circle = new Circle("First Circle", "Red", 45.0);
        Square square = new Square("First Square", "Green", 56.0);

        Console.WriteLine($"{rectangle.GetName()} (Color: {rectangle.GetColor()}) - Area: {rectangle.GetArea()}");
        Console.WriteLine($"{circle.GetName()} (Color: {circle.GetColor()}) - Area: {circle.GetArea()}");
        Console.WriteLine($"{square.GetName()} (Color: {square.GetColor()}) - Area: {square.GetArea()}");
    }
}






