public abstract class Activity 
{
    protected int _duration;
    protected string _date;
    protected string _name;
    

    public Activity(DateTime date, int duration)
    {
        _date = date.ToString("dd MMM yyyy");
        _duration = duration;
    }
    
    public abstract double GetDistance();
    public double GetSpeed()
    {
        return (GetDistance()/_duration )*60;
    }

    public double GetPace()
    {
        return _duration / GetDistance();
    }
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }

    

}