public class Swimming : Activity
{
    private int _laps;
    private const double _lapDistance = 50.0;
    public Swimming (DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * _lapDistance;
    }

}