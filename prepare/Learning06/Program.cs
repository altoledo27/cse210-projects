using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square("Yellow", 4);

        Rectangle shape2 = new Rectangle("Blue", 4.7, 8);

        Circle shape3 = new Circle("Green", 7);

        //DisplayShapeInformation(shape1);
        //DisplayShapeInformation(shape2);
        //DisplayShapeInformation(shape3);
        List<Shape> shapes =  new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("--------------------------");
            double area = shape.GetArea();
            Console.WriteLine($"Color: {shape.GetColor()}.\nArea: {area}cm^2");
            Console.WriteLine("---------------------------");
        }


    }

    public static void DisplayShapeInformation (Shape figure)
    {
        double area = figure.GetArea();
        Console.WriteLine($"Color: {figure.GetColor()}.\nArea: {area}cm^2");

    }
}