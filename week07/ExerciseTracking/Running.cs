public class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance; // returns the distance in km
    }

    public override double GetSpeed()
    {
        // Speed = Distance (km) / Time (hours)
        return _distance / _duration * 60;
    }

    public override double GetPace()
    {
        // Pace = Time (minutes) / Distance (km)
        return _duration / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Running ({_duration} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
