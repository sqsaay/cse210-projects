using System;

namespace Shapes;

public class Circle : Shape
{
    // Private member variable for radius
    private double _radius;

    // Constructor accepts color and radius
    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }

    // Override GetArea() to calculate circle area
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}
