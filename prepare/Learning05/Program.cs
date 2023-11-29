using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Square square = new Square("Red", 43);
        Rectangle rectangle = new Rectangle("Purple", 4.3, 9.26);
        Circle circle = new Circle("white", 45.29);


        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shp in shapes)
        {
            double area = shp.GetArea();
            string color = shp.GetColor();

            Console.WriteLine($"Sahpe: {color} \nShape Area: {area}\n");
        }
    }
}