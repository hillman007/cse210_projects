public class Swimming : Activity
{
    private int _laps; // Number of laps in the pool

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance = Laps * 50 meters, then convert to kilometers or miles
        return _laps * 50 / 1000; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        // Speed = Distance (km) / Time (hours)
        return GetDistance() / _duration * 60;
    }

    public override double GetPace()
    {
        // Pace = Time (minutes) / Distance (km)
        return _duration / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Swimming ({_duration} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
