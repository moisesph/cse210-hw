public class ChecklistGoal : Goal
{

    private int _amountCompleted;

    private int _target;
    private int _bonus;
    private bool _completed;
    private bool _ableSumBonus;
    private int _counterAbleBonus;
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
    public bool setAbleSumBonus()
    {
        _ableSumBonus = true;
        return _ableSumBonus;

    }

    public override void RecordEvent()
    {


        if (_ableSumBonus)
        {
            setCompleted();
        }

        if (_ableSumBonus != true)
        {
               sumPoints(_bonus);
        }

        if (_target >= _amountCompleted && _completed != true)
        {
            _amountCompleted += 1;
            _counterAbleBonus = _amountCompleted;
            sumPoints(_bonus);

        }

        if (_counterAbleBonus > _target && _completed != true)
        {
            setAbleSumBonus();

            _amountCompleted--;
            _counterAbleBonus++;
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

