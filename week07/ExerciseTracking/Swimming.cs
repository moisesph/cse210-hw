public class Swimming : Activity
{
    private float _laps;
    public Swimming(string activityType, string date, float laps, float minutes) : base(activityType, date, minutes)
    {
        _laps = laps;
    }

    public override float ComputeDistance()
    {
        return _laps * 50 / 1000;
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

        return $"{_date}- {_activityType} ({_minutes} min): Distance {ComputeDistance()} km, Speed: {ComputeSpeed():F2} kph, Pace:{ComputePace():F2} min per km.";
    }
}