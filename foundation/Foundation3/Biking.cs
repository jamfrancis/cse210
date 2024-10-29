public class Biking : Activity
{
    private double _speed;

    public Biking(DateTime date, int time, double speed) : base(date, time)
    {
        _speed = speed;
        Distance = GetDistance();
    }

    public override double GetDistance()
    {
        return (Time / 60.0) * _speed;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Biking ({Time} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}