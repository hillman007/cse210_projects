using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime _date;
    protected double _duration; // in minutes

    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance(); // Distance in kilometers or miles
    public abstract double GetSpeed();    // Speed in kph or mph
    public abstract double GetPace();     // Pace in min per km or min per mile

    public abstract string GetSummary();
}