public class Running : Activity
{
    public Running(DateTime date, int time, double distance) : base(date, time)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Running ({Time} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
