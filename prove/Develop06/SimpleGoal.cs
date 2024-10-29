public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override int RecordEvent(GoalManager manager)
    {
        if (!_isComplete)
        {
            manager.AddPoints(_points);
            _isComplete = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete() 
    { 
        return _isComplete;
    } 

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) ";
    }


    public override string GetStringRepresentation() 
    { 
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}"; 
    }
}
