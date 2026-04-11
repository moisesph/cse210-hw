public abstract class Activity
{
    protected string _activityType;
    protected string _date;
    protected float _minutes;

    public Activity(string activityType, string date, float minutes)
    {
        _activityType = activityType;
        _date = date;
        _minutes = minutes;

    }


    public abstract string GetSummary();


    public abstract float ComputeDistance();



    public abstract float ComputeSpeed();


    public abstract float ComputePace();




}