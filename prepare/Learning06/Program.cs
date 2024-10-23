using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square();
        shape1.SetColor("Yellow");
        shape1.SetSide(4);

        Rectangle shape2 = new Rectangle();
        shape2.SetColor("Red");
        shape2.SetSides(4, 5);

        Circle shape3 = new Circle();
        shape3.SetColor("Blue");
        shape3.SetRadius(6);

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