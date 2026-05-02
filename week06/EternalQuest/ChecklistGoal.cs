public class ChecklistGoal : Goal
{

    private int _amountCompleted;

    private int _target;
    private int _bonus;
    private bool _completed;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public bool setCompleted()
    {
        _completed = true;
        return _completed;
    }


    public override void RecordEvent()
    {

        if (_target >= _amountCompleted && _completed != true)
        {
            _amountCompleted += 1;

            sumPoints(_bonus);
        }


    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{getName()} {getDescription()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{getName()},{getDescription()},{getPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}

