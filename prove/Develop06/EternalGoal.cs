public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent(GoalManager manager)
    {
        manager.AddPoints(_points);
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) ";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
