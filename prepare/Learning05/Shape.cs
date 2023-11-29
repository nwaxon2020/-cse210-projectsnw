using System;

public abstract class Shape
{
    private string _color;
    protected string _shapeName;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return $"{_shapeName}\nColour: {_color}";
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    
}