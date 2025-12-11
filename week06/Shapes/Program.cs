using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Shape("red");
        Console.WriteLine(shape1.GetColor());
        Console.WriteLine(shape1.GetArea());

        Square square = new Square("Blue", 5);
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 3, 5));
        shapes.Add(new Circle("yellow", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
    }
}