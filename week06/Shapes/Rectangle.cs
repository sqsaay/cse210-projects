using System;

namespace Shapes;

public class Rectangle : Shape
{
    private double _lenght;
    private double _widht;

    public Rectangle(string color, double lenght, double widht)
    :base (color)
    {
        _lenght = lenght;
        _widht = widht;
    }

    public void SetRectangle(double lenght, double widht)
    {
        _lenght = lenght;
        _widht = widht;
    }

    public override double GetArea()
    {
        return _lenght * _widht;
    }
}
