public class Rectangle : Shape
{

    private double _lenght;
    private double _width;

    public void SetSides(double lenght, double width)
    {
        _lenght = lenght;
        _width = width;
    }


    public override double  GetArea()
    {
        return _lenght * _width;
    }

}