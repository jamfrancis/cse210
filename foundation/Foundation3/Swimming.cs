public class Swimming : Activity
{
    private int _laps;
    private const double PoolLengthMeters = 50.0;

    public Swimming(DateTime date, int time, int laps) : base(date, time)
    {
        _laps = laps;
        Distance = GetDistance();
    }

    public override double GetDistance()
    {
        double distanceMeters = _laps * PoolLengthMeters;
        double distanceMiles = distanceMeters / 1609.34 * 0.62;
        return distanceMiles;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({Time} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}