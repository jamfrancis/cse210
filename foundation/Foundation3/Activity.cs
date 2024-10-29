using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _time;
    private double _distance;

    protected DateTime Date { get => _date; set => _date = value; }
    protected int Time { get => _time; set => _time = value; }
    protected double Distance { get => _distance; set => _distance = value; }

    public Activity(DateTime date, int time)
    {
        _date = date;
        _time = time;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return (_distance / _time) * 60;
    }

    public virtual double GetPace()
    {
        return (double)_time / _distance;
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_time} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}