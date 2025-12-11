using System;

namespace Shapes;

public class Square : Shape
{
    private double _side;


    public Square(string color, float side)
    : base(color)
    {
        _side = side;
        
    }
    public void SetSquare(double side)
    {
        _side = side;
    }

    public double GetSquare()
    {
        return _side;
    }


    public override double GetArea()
    {
        return _side * _side;
    }
}
