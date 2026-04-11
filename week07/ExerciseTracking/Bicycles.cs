public class Bicycles : Activity
{
    private float _speed;
    public Bicycles(string activityType, string date, float speed, float minutes) : base(activityType, date, minutes)
    {
        _speed = speed;
    }

    public override float ComputeDistance()
    {
        return _speed * (_minutes / 60);
    }


    public override float ComputeSpeed()
    {
        return (ComputeDistance() / _minutes) * 60;
    }

    public override float ComputePace()
    {
        return _minutes / ComputeDistance();
    }


    public override string GetSummary()
    {

        return $"{_date}- {_activityType} ({_minutes} min): Distance {ComputeDistance():F2} km, Speed: {ComputeSpeed():F2} kph, Pace:{ComputePace():F2} min per km.";
    }
}