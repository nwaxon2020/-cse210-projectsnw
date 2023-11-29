using System;

public class Square : Shape
{
    private double _side;

    public Square (string color, double side) : base (color)
    {
        _side = side;
        _shapeName = "Square";
    }

    public override double GetArea()
    {
        double area = _side * 2;

        return area;
    }
}