public class Circle : Shape 
{
    private double _radius;

    public Circle(string color, double radio): base(color)
    {
        _radius = radio;
    }

    public override double GetArea()
    {
        return 3.1416 * _radius * _radius;
    }

}