public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent(GoalManager manager)
    {
        if (_amountCompleted < _target - 1)
        {
            manager.AddPoints(_bonus);
            _amountCompleted++;
            return _bonus;
        }
        else
        {
            manager.AddPoints(_points + _bonus);
            _amountCompleted++;
            return _points + _bonus;
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target} ";
    }

    public override string GetStringRepresentation() 
    { 
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}"; 
    }
}