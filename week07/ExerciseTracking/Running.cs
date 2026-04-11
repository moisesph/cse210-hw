public class Running : Activity
{
    private float _distance;
    public Running(string activityType, string date, float distance, float minutes) : base(activityType, date, minutes)
    {

        _distance = distance;
    }

    public override float ComputeDistance()
    {
        return _distance;
    }
    public override float ComputeSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override float ComputePace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date}- {_activityType} ({_minutes} min): Distance {_distance} km, Speed: {ComputeSpeed():F2} kph, Pace:{ComputePace():F2} min per km.";
    }
}

