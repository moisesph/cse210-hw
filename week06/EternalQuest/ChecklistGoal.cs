public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
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

    public override void RecordEvent()
    {

        if (_amountCompleted != _target)
        {
            _amountCompleted += 1;

        }
        if (_amountCompleted >= _target)
        {
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

