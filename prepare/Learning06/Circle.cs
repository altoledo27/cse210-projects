public class Circle : Shape 
{
    private double _radius;

    public void SetRadius(double radio)
    {
        _radius = radio;
    }

    public override double GetArea()
    {
        return 3.1416 * _radius * _radius;
    }

}