using System.Drawing;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;


    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public string getName()
    {
        return _shortName;
    }
    public string getDescription()
    {
        return _description;
    }

    public void setPoints(string points)
    {
        _points = points;
    }

    public void sumPoints(int points)
    {
        int pointsInt = int.Parse(_points);
        pointsInt += points;
        string pointsString = pointsInt.ToString();
        _points = pointsString;
    }
    public string getPoints()
    {
        return _points;
    }


    public abstract void RecordEvent();
    public abstract bool IsComplete();




    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();

}